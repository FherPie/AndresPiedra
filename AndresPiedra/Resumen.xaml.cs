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
    public partial class Resumen : ContentPage
    {
        private string usuario;
        private float valorTotal;
        private float valorMensual;

        public Resumen()
        {
           
        }

        public Resumen(string usuario, float valorTotal, float valorMensual)
        {
            InitializeComponent();
            this.usuario=usuario;
            this.valorTotal=valorTotal;
            this.valorMensual=valorMensual;

            this.txtMensual.Text=valorMensual.ToString();
            this.txtTotal.Text=valorTotal.ToString();
            this.txtNombre.Text=usuario;
        }
    }
}