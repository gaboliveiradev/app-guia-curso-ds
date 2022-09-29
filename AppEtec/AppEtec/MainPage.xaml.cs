using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppEtec.Views;

namespace AppEtec
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
        }

        private async void btn_inicial(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
                IsPresented = false;
            } catch (Exception err)
            {
                await DisplayAlert("Erro", err.Message, "OK");
            }
        }

        private async void btn_primeiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesPrimeiro)));
                IsPresented = false;
            }
            catch (Exception err)
            {
                await DisplayAlert("Erro", err.Message, "OK");
            }
        }

        private async void btn_segundo(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesSegundo)));
                IsPresented = false;
            }
            catch (Exception err)
            {
                await DisplayAlert("Erro", err.Message, "OK");
            }
        }

        private async void btn_terceiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesTerceiro)));
                IsPresented = false;
            }
            catch (Exception err)
            {
                await DisplayAlert("Erro", err.Message, "OK");
            }
        }

        private async void btn_vestibulinho(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Vestibulinho)));
                IsPresented = false;
            }
            catch (Exception err)
            {
                await DisplayAlert("Erro", err.Message, "OK");
            }
        }

        private async void btn_contato(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Contato)));
                IsPresented = false;
            }
            catch (Exception err)
            {
                await DisplayAlert("Erro", err.Message, "OK");
            }
        }
    }
}
