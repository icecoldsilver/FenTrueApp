//Class used to represent a database for testing and holding Project Objects

using System;
using System.Collections.Generic;
using System.Linq;

namespace FenTrue.Models
{
    public class ProjectDB
    {
        //Variable to hold list of projects
        public List<Project> ProjectList = new List<Project>();
        

        public ProjectDB()
        {
        }

       

        //Returns project by last name
        public Project GetProjectByName(string lastName)
        {
            return ProjectList.FirstOrDefault(a=> a.LastName == lastName);
        }

        //Returns project by Project Number
        public Project GetProjectByProjectNumber(string number)
        {
            return ProjectList.FirstOrDefault(a => a.ProjectNumber == number);
        }
    }
}
