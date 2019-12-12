using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenTrue.Models;
using FenTrue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FenTrue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProjectItemView : TabbedPage
    {
        
        public AddProjectItemView()
        {
            InitializeComponent();
            
        }

        public AddProjectItemView(Project project)
        {
            
            Project _project = project;
            ContentPage windowPage = new AddPocketWindowView(_project);
            windowPage.Title = "Windows";
            Children.Add(windowPage);
            //this.Children.Add(new AddPocketWindowView(_project));
        }

       
    }
}
