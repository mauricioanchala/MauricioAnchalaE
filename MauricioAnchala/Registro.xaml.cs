using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MauricioAnchala
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string strUsuario, string strPassword)
        {
            InitializeComponent();
            LblUsuario.Text = "Usuario Conectado: " + strUsuario;
        }

       

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double inicial = Convert.ToDouble(txtPagoi.Text);
            double diferencia = 1800 - inicial;
            double cuotas = Math.Round((diferencia / 3) + (1800 * 0.05),2);

            txtPagom.Text = Convert.ToString(cuotas);
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resumen(txtNombre.Text, txtPagom.Text,txtPagoi.Text,LblUsuario.Text));
        }
    }
}