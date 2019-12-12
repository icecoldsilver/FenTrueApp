using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FenTrue.Models;
using SQLite;
using Xamarin.Forms;

namespace FenTrue.Views
{
    public partial class ProjectDetailView : ContentPage
    {
        //Project _project = new Project();
        private SQLiteAsyncConnection _connection;
        private Project _project = new Project();

        //Default constructor
        public ProjectDetailView()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        //Constructor for loading project detail view 
        public ProjectDetailView(Project project)
        {
            
            InitializeComponent();
            //Gets DB connection
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            //Gets project from database
            var p = _connection.GetAsync<Project>(project.ProjectNumber);
            _project = p.Result;

            //Assigns values to view with selected project info
            projectNumber_Entry.Text = project.ProjectNumber;
            lastName_Entry.Text = project.LastName;
            firstName_Entry.Text = project.FirstName;
            address_Entry.Text = project.Address;
        }

        //Method to edit data
        void OnEditClicked(object sender, System.EventArgs e)
        {
            
            lastName_Entry.IsReadOnly = false;
            firstName_Entry.IsReadOnly = false;
            address_Entry.IsReadOnly = false;

            lastName_Entry.Focus();
            EditButton.IsVisible = false;
            SaveButton.IsVisible = true;
        }

        //Override method to load DB table
        protected override async void OnAppearing()
        {
            //Loads DB on loading
            await _connection.CreateTableAsync<Project>();
            

            base.OnAppearing();
        }

        //Method saves changes to DB and updates view
        async void OnSaveClicked(object sender, System.EventArgs e)
        {
            //Assigns text to labels in view
            _project.ProjectNumber = projectNumber_Entry.Text;
            _project.LastName = lastName_Entry.Text;
            _project.FirstName = firstName_Entry.Text;
            _project.Address = address_Entry.Text;

            //Tests for empty views
            if (string.IsNullOrEmpty(lastName_Entry.Text))
            {
                LastNameRequired_ErrorMSG.IsVisible = true;
                return;
            }

            if (string.IsNullOrEmpty(firstName_Entry.Text))
            {
                FirstNameRequired_ErrorMSG.IsVisible = true;
                return;
            }

            if (string.IsNullOrEmpty(address_Entry.Text))
            {
                AddressRequired_ErrorMSG.IsVisible = true;
                return;
            }


            //Updates selected project in DB
            await _connection.UpdateAsync(_project);
            await DisplayAlert("Success!", _project.ProjectNumber + "\n" + _project.LastName, "OK");

            //Loads List View 
            await Navigation.PushAsync(new ViewProjectsView());
        }
    }
}
