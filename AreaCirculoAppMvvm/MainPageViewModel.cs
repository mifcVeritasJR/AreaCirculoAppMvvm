using System;
using System.ComponentModel;
using System.Windows.Input;

namespace AreaCirculoAppMvvm
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _radio;
        private string _resultado;

        public string Radio
        {
            get => _radio;
            set
            {
                if (_radio != value)
                {
                    _radio = value;
                    OnPropertyChanged(nameof(Radio));
                }
            }
        }

        public string Resultado
        {
            get => _resultado;
            set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        public ICommand CalcularAreaCommand { get; }

        public ICommand LimpiarCommand { get; }

        public MainPageViewModel()
        {
            CalcularAreaCommand = new Command(CalcularArea);
            LimpiarCommand = new Command(Limpiar);
        }

        private void CalcularArea()
        {
            if (double.TryParse(Radio, out double radio))
            {
                if (radio > 0)
                {
                    double area = Math.PI * Math.Pow(radio, 2);
                    Resultado = $"Área: {area:F2}";
                }
                else
                {
                    Resultado = "El radio debe ser mayor que 0";
                }
            }
            else
            {
                Resultado = "Por favor ingrese un valor numérico válido";
            }
        }

        private void Limpiar()
        {
            Radio = string.Empty;
            Resultado = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}