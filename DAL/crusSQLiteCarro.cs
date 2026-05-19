using appProvaRegimental.Model;
using SQLite;
using System.Security.Cryptography.X509Certificates;
namespace appProvaRegimental.DAl
{
    public class crudSQLiteCarro
    {
        readonly SQLiteAsyncConnection _conexao;
        public crudSQLiteCarro(string path)
        {
            _conexao = new SQLiteAsyncConnection(path);
            _conexao.CreateTableAsync<Carro>().Wait();
        }
        public Task<int> Insert(Carro carro1)
        {
            return _conexao.InsertAsync(carro1);
        }
        public Task<List<Carro>> Update(Carro carro1)
        {
            string sql = "UPDATE Carro SET carNome = ?, carPlaca = ? WHERE carID = ?";
            return _conexao.QueryAsync<Carro>(sql, carro1.carNome, carro1.carPlaca, carro1.carID);
        }
        public Task<List<Carro>> GetAll()
        {
            return _conexao.Table<Carro>().ToListAsync();
        }
        public Task<int> Delete(int idCar)
        {
            return _conexao.Table<Carro>().DeleteAsync(i => i.carID == idCar);
        }
        public Task<List<Carro>> Search(string buscaCarro)
        {
            string sql = "SELECT * FROM Carro WHERE carNome LIKE '%" + buscaCarro + "%'";
            return _conexao.QueryAsync<Carro>(sql);
        }
    }
}