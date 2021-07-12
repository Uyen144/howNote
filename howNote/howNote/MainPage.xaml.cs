using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace howNote
{
    public partial class MainPage : ContentPage
    {
        public ImageSource Source { get; set; }
        public MainPage()
        {
            InitializeComponent(); 
        }
        void Handle_Clicked(object sender,EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }
        
    }
}
