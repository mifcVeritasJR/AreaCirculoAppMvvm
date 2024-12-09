namespace AreaCirculoAppMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Se establece el Shell como la página principal
            MainPage = new AppShell();
        }
    }
}
