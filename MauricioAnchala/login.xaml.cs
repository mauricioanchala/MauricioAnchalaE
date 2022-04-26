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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void BtnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string clave = TxtPass.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(TxtUsuario.Text, TxtPass.Text));
            }
            else
            {
                DisplayAlert("Error", "Usuario Incorrecto", "Aceptar");
            }
        }
    }
}