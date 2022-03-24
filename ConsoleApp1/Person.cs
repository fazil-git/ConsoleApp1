using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string name;
        public int age;
        protected string laptop;

        public Person()
        {
            Console.WriteLine("Person class empty constructor invoked");
        }
        public Person(string name, int age, string laptop)
        {
            this.name = name;
            this.age = age;
            this.laptop = laptop;
            Console.WriteLine("Person class paramaterized constructor invoked");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Laptop
        {
            get { return laptop; }
            set { laptop = value; }
        }

        //method over-loading
        internal void rideVehicle(Vehicle vehicle)
        {
            Console.WriteLine("You are riding vehicle bike having wheels = " + vehicle.Wheels);
        }
        internal void rideVehicle(Bike bike)
        {
            Console.WriteLine("You are riding vehicle bike having wheels = " + bike.Wheels);
        }
        internal void rideVehicle(Boat boat)
        {
            Console.WriteLine("You are riding vehicle boat having wheels = "+ boat.Wheels);
        }
    }
}
