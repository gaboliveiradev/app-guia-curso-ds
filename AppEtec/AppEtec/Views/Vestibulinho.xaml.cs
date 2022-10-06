using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vestibulinho : ContentPage
    {
        public Vestibulinho()
        {
            InitializeComponent();
        }

        private async void btnOpenUri(object sender, EventArgs e)
        {
            try
            {
                //Device.OpenUri(new Uri("http://www.vestibulinhoetec.com.br"));
            } catch (Exception err)
            {
                await DisplayAlert("Ops!", err.Message, "OK");
            }
        }
    }
}