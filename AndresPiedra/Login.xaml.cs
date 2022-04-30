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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contra = txtContrasma.Text;

            if (usuario == "AP2022" && contra == "123")
            {
                Navigation.PushAsync(new Registro(usuario, contra));
            }
            else
            {
                DisplayAlert("Error", "Credenciales Incorrectas", "Cerrar");
            }

        }
    }
}