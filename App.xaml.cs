using appProvaRegimental.DAl;
using appProvaRegimental.Views;
namespace appProvaRegimental
{
    public partial class App : Application
    {
        static crudSQLite? database;

        public static crudSQLite Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "carros.db3");
                    database = new crudSQLite(path);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TelaListaCarro());
        }
    }
}