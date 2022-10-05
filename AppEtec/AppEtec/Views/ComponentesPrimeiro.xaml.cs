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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void btnLinguagem(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            } catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnAlgoritmos(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnBanco(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnAnalise(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnDesign(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnWeb(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnFundamentos(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnTecnicas(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "",
                    AtribuicoesResponsabilidades = "",
                    ValoresAtitudes = ""
                };
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }
    }
}