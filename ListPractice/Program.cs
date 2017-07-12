using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> favNum = new List<int>();//instanitate a empty list
            favNum.Add(7);//add the number seven to the list
            favNum.Add(25);
            favNum.Add(30);
            foreach( int number in favNum)
            {
                Console.Write("{0} ",number);
            }
            List<string> name = new List<string> { "pete", "tom", "paige", "hope" };//instantiats and assigns name list

            foreach (string nameStr in name)
            {
                Console.Write("{0} ", nameStr);
            }

            name.Insert(0, "Daniel");//inserts Daniel at index 0 while moving the rest of the list to the right

            foreach (string nameStr in name)
            {
                Console.Write("{0} ", nameStr);
            }

            List<string> animals = new List<string>();
            animals.Add("dog");
            animals.Add("cat");
            animals.Add("parrot");
            animals.Add("horse");
            animals.Add("monkey");

            for (int i = 0; i < animals.Count; i++)
            {
                Console.Write("{0} ", animals[i]);
            }

            Console.Write("\n");

            List<bool> checkBool = new List<bool> { true, false, false, false, false };

           for (int i = 0; i < checkBool.Count; i++)
            {
                if (checkBool[i] == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }else
                {
                    Console.WriteLine("No rain today enjoy the sun");

                }
            }

            List<string> favFoods = new List<string> { "pizza", "corn", "chicken" };

           
                if(favFoods.Contains("pizza")== true)
                {
                    Console.WriteLine("\ntime to eat\n");
                }else
                {
                    Console.WriteLine("\nIm hungry\n");
                }
            
        }


}
}
