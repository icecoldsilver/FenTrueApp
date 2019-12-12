using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenTrue.Models;
using FenTrue.Views;
using Xamarin.Forms;

namespace FenTrue
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AnimateLogo();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainMenuView());
        }

        private void AnimateLogo()
        {
            logo.FadeTo(1,1000);
            logo.ScaleTo(1,1000);
        }
        
        
        
        
    }
}
