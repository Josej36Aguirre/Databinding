using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Databinding
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            botonEnviar.Clicked += BotonEnviar_clicked;
		}

        private void BotonEnviar_clicked(object sender, EventArgs e)
        {
            var per = (Persona)Resources["PersonaUno"];
            per.Nombre = "Jose";
            per.Pais = "Argentina";
        }

    }
}
