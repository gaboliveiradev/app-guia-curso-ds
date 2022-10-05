using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppEtec.Models;

namespace AppEtec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void btnDs(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnBancoII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnEtica(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnMobile(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnWebII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnSE(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }
    }
}