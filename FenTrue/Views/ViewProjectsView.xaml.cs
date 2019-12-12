using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FenTrue.Models;
using FenTrue.Views;
using SQLite;
using Xamarin.Forms;

namespace FenTrue.Views
{
    public partial class ViewProjectsView : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Project> _projects;

        public ViewProjectsView()
        
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            
            
        }

        protected override async void OnAppearing()
        {
           await _connection.CreateTableAsync<Project>();

            var projects = await _connection.Table<Project>().ToListAsync();
            _projects = new ObservableCollection<Project>(projects);
            projectListView.ItemsSource = _projects;
            projectListView.HasUnevenRows = true;
            
            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            //var project = new Project { ProjectNumber = "300902", LastName = "Jones" };
            await Navigation.PushAsync(new CreateNewProjectView());
            //await _connection.InsertAsync(project);

            //_projects.Add(project);
        }

        void OnUpdate(object sender, System.EventArgs e)
        {

        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var project = (sender as MenuItem).CommandParameter as Project;
            await _connection.DeleteAsync(project);
            _projects.Remove(project);
        }

        async void ListItemDelete_Clicked(object sender, System.EventArgs e)
        {
            var project = (sender as MenuItem).CommandParameter as Project;
            var answer = await DisplayAlert("Are you sure you want to delete this project?",project.ProjectNumber.ToString() + "\n" + project.LastName, "OK", "Cancel");
            if (answer)
                OnDelete(sender,e);
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var project = e.SelectedItem as Project;
            await Navigation.PushAsync(new ProjectDetailView(project));
        }
    }

}
