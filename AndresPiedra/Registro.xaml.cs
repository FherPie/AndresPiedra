using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndresPiedra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            
        }

        public Registro(string usuario, string contra)
        {
            InitializeComponent();
            Usuario = usuario;
            Contra = contra;
            lblBievenida.Text = "Bienvenido usuario " + usuario;
        }

        public string Usuario { get; }
        public string Contra { get; }

        private const float costoCurso = 3000;

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(" ") || String.IsNullOrEmpty(txtNombre.Text))
            {
                await DisplayAlert("Muestre el nombre", "Ingrese el Nombre", "OK");
            }
            else if (float.Parse(txtMontoInicial.Text) > costoCurso)
            {
                await DisplayAlert("Advertencia", "EL monto inicial no puede ser mayor a costo de curso que es " + costoCurso, "OK");

            }
            else {
                float valorMensual = (float)(costoCurso/5+costoCurso*0.05);
                txtPagoMen.Text= valorMensual.ToString("0.00");
                float montoInicial = float.Parse(txtMontoInicial.Text);
                float valorTotal= (float)(valorMensual*5+montoInicial);

                await Navigation.PushAsync(new Resumen(this.Usuario, valorTotal, valorMensual));

            }
        }
    }
}