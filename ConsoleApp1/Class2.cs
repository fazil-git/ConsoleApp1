using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Creature
    {
        private int claws;

        public Creature()
        {
            claws=0;
        }
        public Creature(int claws)
        {
            Claws = claws;
        }
        public int Claws
        {
            get { return claws; }
            set { claws = value; }
        }
        //Auto property (or) auto implement property
        public string Bite { get; set; }
    }

    class Vampire : Creature
    {

    }
    class Warewolf : Creature
    {

    }
}
