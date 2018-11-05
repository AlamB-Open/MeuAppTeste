using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MeuAppForms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void GiraLabel(object sender, EventArgs args)
        {
            await label.RelRotateTo(360, 1000);
        }

        void MudaTextoLabel(object sender, EventArgs args)
        {
            label.Text = "Mudei!";
        }

        void PrecionaBtnSucesso(object sender, EventArgs args)
        {
            btnSucesso.Image = "verdeDown.png";
        }

        void SoltaBtnSucesso(object sender, EventArgs args)
        {
            btnSucesso.Image = "verdeUp.png";
        }

        void PrecionaBtnErro(object sender, EventArgs args)
        {
            btnErro.Image = "vermelhoDown.png";
        }

        void SoltaBtnErro(object sender, EventArgs args)
        {
            btnErro.Image = "vermelhoUp.png";
        }

    }
}
