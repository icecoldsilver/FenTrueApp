//Class used for creating project items and
//to hold item information for processing

using System;
using System.Collections;
using System.Collections.Generic;


namespace FenTrue.Models
{
    public class ProjectItem
    {
        //General Item Variables
        //private string itemStyle;
        //private string itemType;
        //private string itemLocation;
        //private string itemBrand;
        //private int itemTotalUnits;
        //private int itemTotalOpenings;
        //private bool lead = false;
        //private string itemNotes;
        //private ArrayList itemImageList;

        ////Specific variables for Items
        //private string grids;
        //private string gridType;
        //private string claddingColor;
        //private string interiorCasingType;
        //private string interiorCasingStyle;
        //private string interiorCasingColor;
        //private string exteriorCasingType;
        //private string exteriorCasingStyle;
        //private string exteriorCasingColor;
        //private string exteriorCovering;

        ////Order size variables
        //private double orderWidth;
        //private double orderHeight;

        

        public ProjectItem()
        {
        }

        //General Properties of Items

        //property describes the item style for display...single entry, double hung, etc.
        public string ItemStyle { get; set; }
        //property that describes what type of item it is...Window, Door, etc.
        public string ItemType { get; set; }
        //proptery that describes the location of the item
        public string ItemLocation { get; set; }
        //property to describe the brand of item
        public string ItemBrand { get; set; }
        //property for total number of units in location
        public int ItemTotalUnits { get; set; }
        //property for total number of openings in location
        public int ItemTotalOpenings { get; set; }
        //property for lead testing
        public bool ItemLead { get; set; }
        //property for item notes
        public string ItemNotes { get; set; }
        //propety to store image pathnames
        public ArrayList ItemImageList { get; set; }

        //Specific Properties of Items
        //Grid pattern
        public string Grids { get; set; }
        //Type of grid in unit
        public string GridType { get; set; }

        //Color of exterior cladding
        public string CladdingColor { get; set; }
        //Type of interior trim on window
        public string InteriorCasingType { get; set; }
        //Style of interior casing, picture framed or stool and apron
        public string InteriorCasingStyle { get; set; }
        //Color of interior casing
        public string InteriorCasingColor { get; set; }
        //Described the type of exterior casing
        public string ExteriorCasingType { get; set; }
        //Describes the type of exterior casing style, pic frame or sill nose
        public string ExteriorCasingStyle { get; set; }
        //Describes the color of exteiror trim
        public string ExteriorCasingColor { get; set; }
        //Type of wall covering on the home, brick, stucco, etc. 
        public string ExteriorCovering { get; set; }

        //Order size properties

        //Actual width to order item
        public double OrderWidth { get; set; }
        //Actual height to order item
        public double OrderHeight { get; set; }

    }
}
