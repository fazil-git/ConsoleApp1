using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        private string? start;
        private int? end;
        private int? run;

        public string Start { 
            get { return "started"; }
            set {
                if (value.Equals("Key"))
                {
                    start = value;
                }
            } 
        }
        public int Run { get; set; }
        public int Stop { get; set; }
        public virtual int Wheels { get; set;  }
    }
    class Car : Vehicle
    {
        public override int Wheels { get { return 4; } set { } }
    }
    class Bike : Vehicle
    {
        public override int Wheels { get { return 2; } set { } }
    }
    class Boat : Vehicle
    {
        public override int Wheels { get { return 0; } set { } }
    }

    interface IAssociate
    {
        void work();
    }
    interface IEngineer
    {
        void lead();
    }
    interface IManager
    {
        void manageAll();
    }
}
