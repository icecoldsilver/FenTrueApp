using System;
using System.Collections.Generic;
using FenTrue.Models;

using Xamarin.Forms;

namespace FenTrue.Views
{
    public partial class MainMenuView : ContentPage
    {
        
        public MainMenuView()
        {

            InitializeComponent();

            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            connection.CreateTableAsync<Project>();
            

        }

        async void Handle_NewProject_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CreateNewProjectView());
        }

        async void Handle_ViewProjects_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewProjectsView());
        }


    }
}
