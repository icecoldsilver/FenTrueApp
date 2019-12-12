using System;
using FenTrue.Models;

namespace FenTrue.ViewModels
{
    public class AddProjectItemVM
    {
        public AddProjectItemVM()
        {
        }

        public AddProjectItemVM(Project project)
        {
            string projectNumber = project.ProjectNumber;
            string lastName = project.LastName;
            string firstName = project.FirstName;
            string address = project.Address;
        }

        public string ProjectNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
    }
}
