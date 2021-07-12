using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace howNote
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        void Clicked_back(object sender, EventArgs e)//clicked back button
        {
            App.Current.MainPage = new MainPage();

        }
        void Clicked_new(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new Page2();
        }
    }
}