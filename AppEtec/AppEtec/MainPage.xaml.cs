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

        private void btn_inicial(object sender, EventArgs e)
        {

        }

        private void btn_primeiro(object sender, EventArgs e)
        {

        }

        private void btn_segundo(object sender, EventArgs e)
        {

        }

        private void btn_terceiro(object sender, EventArgs e)
        {

        }

        private void btn_vestibulinho(object sender, EventArgs e)
        {

        }

        private void btn_contato(object sender, EventArgs e)
        {

        }
    }
}
