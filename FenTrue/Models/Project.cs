//Class used to hold Project Information and Project Items

using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;
using FenTrue.ViewModels;
using System.ComponentModel;

namespace FenTrue.Models
{
    
    public class Project : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, Required]
        public string ProjectNumber { get; set; }

        private string _lastName;
        private string _firstName;
        private string _address;

        [SQLite.MaxLength(255), Required]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value)
                    return;
                _lastName = value;

                OnPropertyChanged(nameof(LastName));
                
            }
        }

        

        [SQLite.MaxLength(255), Required]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value)
                    return;
                _firstName = value;

                OnPropertyChanged(nameof(FirstName));

            }
        }

        [SQLite.MaxLength(255), Required]
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address == value)
                    return;
                _address = value;

                OnPropertyChanged(nameof(Address));

            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //public List<ProjectItem> Items { get; set; }


        //No-arg Constructor
        public Project()
        {

        }

        

        public override string ToString()
        {
            return ProjectNumber + " " + LastName + " " + FirstName + " " + Address;
        }

    }
    
    
}
