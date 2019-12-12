//Class to create and hold info for Pocket Windows


using System;
using FenTrue.Models;
namespace FenTrue.Models
{
    public class PocketWindow : ProjectItem
    {
        //private static string removalType;
        //private string installType;
        //private double jambWidth;
        //private double jambHeight;
        //private bool replaceSill = false;
        //private bool replaceNose = false;
        //private bool replaceExteriorCasing = false;
        //private string notes;

        public PocketWindow()
        {
            
        }


        //Properties

        //Property that describes method of window removal
        public string RemovalType { get; set; }
        //Describes the installation type
        public string InstallType { get; set; }
        //The jamb width measurement
        public double JambWidth { get; set; }
        //The jamb height measurement
        public double JambHeight { get; set; }

        //Booleans for replacing trim
        public bool ReplaceSill { get; set; }
        public bool ReplaceNose { get; set; }
        public bool ReplaceExteriorCasing { get; set; }
        



    }
}
