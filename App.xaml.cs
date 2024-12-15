using MolnarIozsefLabor7.Data;
namespace MolnarIozsefLabor7
{
    public partial class App : Application
    {
        static ShopListDatabase database;

        public static ShopListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
ShopListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
