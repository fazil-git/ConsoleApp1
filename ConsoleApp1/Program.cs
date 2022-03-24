using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer minimum value = {0} ", int.MinValue);
            Console.WriteLine("Integer maximum value = "+int.MaxValue);
            string s1 = "5";
            int i1 = int.Parse(s1);
            Console.WriteLine(s1.GetType());
            Console.WriteLine(s1.Length);

            string name = "Fazil Ahamed";
            Console.WriteLine(name.Substring(2, name.Length-2));

            object[] objArr = new object[3];
            objArr[0] = 1;
            objArr[1] = "Faz";
            objArr[2] = true;
            foreach (object obj in objArr)
            {
                Console.Write(obj + " " + obj.GetType()+", ");
            }
            for(int i = 0; i < objArr.Length; i++)
            {
                Console.Write(objArr[i]+", ");
            }
            Person person = new Person();
            person.name = "Zog";
            person.age = 24;
            Console.WriteLine();
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);

            Person fazil = new Fazil();
            fazil.name = "fazil";
            fazil.age = 24;

            Vehicle vehicle= new Bike();
            
            fazil.rideVehicle(new Boat());
            //fazil.lead();

            List<string> fruits = new List<string>
            {
                "Apple",
                "Cucumber",
                "Durian",
                "Elderberry"
            };
            fruits.Add("Fresco");
            //fruits.Remove("Durian");
            //fruits.RemoveAt(0);
            fruits.Insert(1, "Banana");
            Console.WriteLine("total fruits : "+fruits.Count);
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }




        }
    }
}
