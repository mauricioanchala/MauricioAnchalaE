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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre,string pagom, string pagoi,string usuario)
        {
            InitializeComponent();
            LblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            double total = (Convert.ToDouble(pagom) * 3) +Convert.ToDouble(pagoi);
            txtPagar.Text = Convert.ToString( total);
        }
    }
}