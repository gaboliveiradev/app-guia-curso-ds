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

        private async void btnBanco(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados I",
                    AtribuicoesResponsabilidades = "Modelar banco de dados",
                    ValoresAtitudes = "Estimular a organização. Fortalecer a persistência e o interesse na resolução de situações-problema. Promover ações qie considerem o respeito ás normas estabelecidas."
                };

                await Navigation.PushAsync(new VerComponentes(c));
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
                    Nome = "Análise e Projeto de Sistemas",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.",
                    ValoresAtitudes = "Estimular a organização. Incentivar a criatividade. Fortalecer a persistência e o interesse na resolução de situações-problemas."
                };

                await Navigation.PushAsync(new VerComponentes(c));
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
                    Nome = "Design Digital",
                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e site.",
                    ValoresAtitudes = "Incentivar a criatividade. Respeitar as manifestações culturais de outros povos. Incentivar ações que promovem a cooperação."
                };

                await Navigation.PushAsync(new VerComponentes(c));
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
                    Nome = "Programação Web I",
                    AtribuicoesResponsabilidades = "Desenvolver sites para Web",
                    ValoresAtitudes = "Incentivar a criatividade. Estimular a organização. Fortalecer a persistência e o interesse na resolução de situações-problemas."
                };

                await Navigation.PushAsync(new VerComponentes(c));
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
                    Nome = "Fundamentos da Informática",
                    AtribuicoesResponsabilidades = "Operar sistemas computacionais.",
                    ValoresAtitudes = "Desenvolver a criaticidade. Incentivar comportamentos éticos. Promover ações que considerem o respeito ás normas estabelecidas."
                };

                await Navigation.PushAsync(new VerComponentes(c));
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
                    Nome = "Técnicas de Programação e Algoritmos",
                    AtribuicoesResponsabilidades = "Desenvolver programas de computador, utilizando princípios de boas práticas. Realizar versionamento no desenvolvimento de programas. Verificar usabilidade no desenvolvimento de programas.",
                    ValoresAtitudes = "Incentivar a criatividade. Incentivar comportamentos éticos. Fortalecer a persistência e o interesse na resolução de situações-problemas."
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