using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FenTrue.Models;
using FenTrue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FenTrue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPocketWindowView : ContentPage
    {
        

        public AddPocketWindowView()
        {
            InitializeComponent();
  
        }

        public AddPocketWindowView(Project project)
        {
            InitializeComponent();
            ProjectNumber.Text = project.ProjectNumber;
            LastName.Text = project.LastName;
            
        }



    }
}
