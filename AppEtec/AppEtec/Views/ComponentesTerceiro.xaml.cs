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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void btnSSI(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente()
                {
                    Nome = "Segurança de Sistemas de Informação  ",
                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação. ",
                    ValoresAtitudes = "Estimular atitudes respeitosas. • Incentivar comportamentos éticos. • Desenvolver a criticidade.  "
                };

                await Navigation.PushAsync(new VerComponentes(c));
            } catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnMobileII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente()
                {
                    Nome = "Programação de Aplicativos Mobile II ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis. ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Incentivar a criatividade. • Estimular a organização "
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnWebIII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente()
                {
                    Nome = "Programação Web III  ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnSEII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente()
                {
                    Nome = "Sistemas Embarcados II",
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

        private async void btnTesteSoft(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente()
                {
                    Nome = "Qualidade e Teste de Software  ",
                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas. • Elaborar registros e planilhas de acompanhamento e controle das atividades.  ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a proatividade. • Desenvolver criticidade. • Incentivar comportamentos éticos "
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }

        private async void btnTcc(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente()
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas   ",
                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.  ",
                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas. • Demonstrar comprometimento com equipe e o trabalho.  "
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