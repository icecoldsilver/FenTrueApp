using System;
using System.Collections.Generic;
using FenTrue.Helpers;
using FenTrue.Models;
using FenTrue.ViewModels;
using SQLite;
using Xamarin.Forms;

namespace FenTrue.Views
{
    public partial class CreateNewProjectView : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private Project _project = new Project();
        

        public CreateNewProjectView()
        {
            InitializeComponent();
            
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Project>();
            
            //var projects = await _connection.Table<Project>().ToListAsync();
            
            base.OnAppearing();
        }

        async void Add_Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddProjectItemView());
        }

        void OnFocus(object sender, System.EventArgs e)
        {
            if (projectNumber_Entry.IsFocused)
                ProjectRequired_ErrorMSG.IsVisible = false;
            if (lastName_Entry.IsFocused)
                LastNameRequired_ErrorMSG.IsVisible = false;
            if (firstName_Entry.IsFocused)
                FirstNameRequired_ErrorMSG.IsVisible = false;
            if (address_Entry.IsFocused)
                AddressRequired_ErrorMSG.IsVisible = false;
        }


        

        async void OnSaveClicked(object sender, System.EventArgs e)
        {

            _project.ProjectNumber = projectNumber_Entry.Text;
            _project.LastName = lastName_Entry.Text;
            _project.FirstName = firstName_Entry.Text;
            _project.Address = address_Entry.Text;

            if (string.IsNullOrEmpty(projectNumber_Entry.Text) || string.IsNullOrEmpty(lastName_Entry.Text) ||
                string.IsNullOrEmpty(firstName_Entry.Text) || string.IsNullOrEmpty(address_Entry.Text))
            {

                ProjectRequired_ErrorMSG.IsVisible = true;
                LastNameRequired_ErrorMSG.IsVisible = true;
                FirstNameRequired_ErrorMSG.IsVisible = true;
                AddressRequired_ErrorMSG.IsVisible = true;
                return;
            }


            await _connection.InsertAsync(_project);
            await DisplayAlert("Success!", _project.ProjectNumber + "\n" + _project.LastName, "OK");
            
            //await Navigation.PushAsync(new AddProjectItemView(_project));

            projectNumber_Entry.Text = null;
            lastName_Entry.Text = null;
            firstName_Entry.Text = null;
            address_Entry.Text = null;
            await Navigation.PushAsync(new ViewProjectsView());
        }
    }
}
