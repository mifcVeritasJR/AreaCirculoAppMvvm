using AreaCirculoAppMvvm;

namespace AreaCirculoAppMvvm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(); // Asegúrate de que esta línea esté presente
        }
    }
}

