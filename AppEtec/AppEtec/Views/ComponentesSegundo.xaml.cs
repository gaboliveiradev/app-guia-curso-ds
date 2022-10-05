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
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. • Codificar e depurar programas. ",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar ações que promovam a cooperação. • Desenvolver a criatividade. "
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
                    Nome = "Banco de Dados II ",
                    AtribuicoesResponsabilidades = "Implementar banco de dados. ",
                    ValoresAtitudes = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a persistência e o interesse na resolução de situações-problema "
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
                    Nome = "Ética e Cidadania Organizacional",
                    AtribuicoesResponsabilidades = "Atuar de acordo com princípios éticos nas relações de trabalho.",
                    ValoresAtitudes = "Estimular atitudes respeitosas. • Incentivar comportamentos éticos. • Comprometer-se com a igualdade de direitos."
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
                    Nome = "Programação de Aplicativos Mobile I ",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. ",
                    ValoresAtitudes = "Incentivar a criatividade. • Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a organização.  "
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
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade.  "
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
                    Nome = "Sistemas Embarcados  ",
                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados.  ",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Estimular a organização. • Incentivar a criatividade. "
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