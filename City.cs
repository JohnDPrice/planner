using System;

namespace Planner
{
    public class City {
        private string _designer = "John Price";
        public string GetDesigner() 
        {
            return _designer;
        }
        private DateTime _dateConstructed { get; set; }
        public DateTime GetTime()
        {
            return _dateConstructed;
        }
        private string _address { get; set; }
        public string GetAddress() 
        {
            return _address;
        }
        private string _owner {get; set;}
        public string GetOwner()
        {
            return _owner;
        }

        // Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        // A readonly property
        public double Volume 
        {
            get
            { 
                return Width * Depth * (3 * Stories);
            }
        }

        // Constructor
        public City(string address) {
            _address = address;
        }

        // Methods
        public void Construct() 
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaseName) 
        {
            _owner = purchaseName;
        }
    }
}