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
    public partial class VerComponentes : ContentPage
    {
        public VerComponentes(Componente c)
        {
            InitializeComponent();
            BindingContext = c;
        }
    }
}