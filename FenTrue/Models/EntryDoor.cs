//Class to create and hold info for Entry Doors

using System;
namespace FenTrue.Models
{
    public class EntryDoor : ProjectItem
    {
        //Variables for recording measurements
        //private string entryDoorType;
        //private double interiorJambWidth;
        //private double interiorJambHeight;
        //private double exteriorJambWidth;
        //private double exteriorJambHeight;
        //private double masonryWidth;
        //private double masonryHeight;
        //private string jambDepth = "4 9/16";
        //private string backset = "2 3/8";

        ////Measure details variables
        //private bool bottomOfAluminumSill = false;
        //private bool topOfWoodSill = false;
        //private bool exteriorCasingAttached = false;
        //private bool measureBetweenCasing = false;
        //private double sillThickness;
        //private string floorType;
        //private string interiorCasingReveal;

        //private double unitOrderWidth;
        //private double unitOrderHeight;
        //private string swing;
        //private string operableDoor;
        //private string interiorDoorColor;
        //private string exteriorDoorColor;
        //private string shoemoldColor;
        //private string hardwareColor;
        //private bool hardwareOperableOnly = true;

        public EntryDoor()
        {
        }

        public string EntryDoorType { get; set; }
        public double InteriorJambWidth { get; set; }
        public double InteriorJambHeight { get; set; }
        public double ExteriorJambWidth { get; set; }
        public double ExteriorJambHeight { get; set; }
        public double MasonryWidth { get; set; }
        public double MasonryHeight { get; set; }
        public string JambDepth { get; set; }
        public string Backset { get; set; }

        public bool BottomOfAluminumSill { get; set; }
        public bool TopOfWoodSill { get; set; }
        public bool ExteriorCasingAttached { get; set; }
        public bool MeasureBetweenCasing { get; set; }
        public double SillThickness { get; set; }
        public string FloorType { get; set; }
        public string InteriorCasingReveal { get; set; }

        public double UnitOrderWidth { get; set; }
        public double UnitOrderHeight { get; set; }
        public string Swing { get; set; }
        public string OperableDoor { get; set; }
        public string InteriorDoorColor { get; set; }
        public string ExteriorDoorColor { get; set; }
        public string ShoemoldColor { get; set; }
        public string HardwareColor { get; set; }
        public bool HardwareOperableOnly { get; set; }
    }
}
