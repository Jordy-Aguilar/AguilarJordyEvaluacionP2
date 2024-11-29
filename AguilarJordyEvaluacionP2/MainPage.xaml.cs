using System;
using Microsoft.Maui.Controls;

namespace AguilarJordyEvaluacionP2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void JBtn_Recargar_Click(object sender, EventArgs e)
        {
            string numero = JTex_Numero.Text;
            string operador = JAguilar_Operador.SelectedItem?.ToString();
            string monto = null;

            if (JRad_Monto3.IsChecked) monto = "3";
            else if (JRad_Monto5.IsChecked) monto = "5";
            else if (JRad_Monto10.IsChecked) monto = "10";

            if (string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(operador) || string.IsNullOrEmpty(monto))
            {
                JAguilar_Resumen.Text = "Por favor complete todos los campos.";
            }
            else
            {
                JAguilar_Resumen.Text = $"Número: {numero}\nOperador: {operador}\nMonto: {monto}";
            }
        }
    }
}
