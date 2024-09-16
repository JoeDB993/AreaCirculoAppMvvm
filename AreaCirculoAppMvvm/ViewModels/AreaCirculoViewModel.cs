using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class AreaCirculoViewModel : ObservableObject
    {
        private const double Pi = Math.PI; // O usa Pi definido manualmente

        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private string resultado;

        public AreaCirculoViewModel()
        {
            LimpiarCampos();
        }

        [RelayCommand]
        void CalcularArea()
        {
            if (Radio > 0)
            {
                double area = Pi * Math.Pow(Radio, 2);
                Resultado = $"Área: {area:F2}";
            }
            else
            {
                Resultado = "Ingresa un valor válido para el radio";
            }
        }

        [RelayCommand]
        void LimpiarCampos()
        {
            Radio = 0;
            Resultado = string.Empty;
        }
    }
}
