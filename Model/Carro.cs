using SQLite;

namespace appProvaRegimental.Model
{
    [Table("Carro")]
    public class Carro
    {
        [PrimaryKey, AutoIncrement, Unique, NotNull]
        public int carID { get; set; }
        [MaxLength(1000)]
        public string carNome { get; set; }
        [MaxLength(7)]
        public string carPlaca { get; set; }
    }
}