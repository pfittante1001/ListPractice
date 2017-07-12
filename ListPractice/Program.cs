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
            // List<int> favNum = new List<int>();//instanitate a empty list
            // favNum.Add(7);//add the number seven to the list
            // favNum.Add(25);
            // favNum.Add(30);
            // foreach( int number in favNum)
            // {
            //     Console.Write("{0} ",number);
            // }
            // List<string> name = new List<string> { "pete", "tom", "paige", "hope" };//instantiats and assigns name list

            // foreach (string nameStr in name)
            // {
            //     Console.Write("{0} ", nameStr);
            // }

            // name.Insert(0, "Daniel");//inserts Daniel at index 0 while moving the rest of the list to the right

            // foreach (string nameStr in name)
            // {
            //     Console.Write("{0} ", nameStr);
            // }

            // List<string> animals = new List<string>();
            // animals.Add("dog");
            // animals.Add("cat");
            // animals.Add("parrot");
            // animals.Add("horse");
            // animals.Add("monkey");

            // for (int i = 0; i < animals.Count; i++)
            // {
            //     Console.Write("{0} ", animals[i]);
            // }

            // Console.Write("\n");

            // List<bool> checkBool = new List<bool> { true, false, false, false, false };

            //for (int i = 0; i < checkBool.Count; i++)
            // {
            //     if (checkBool[i] == true)
            //     {
            //         Console.WriteLine("Better bring an umbrella");
            //     }else
            //     {
            //         Console.WriteLine("No rain today enjoy the sun");

            //     }
            // }

            // List<string> favFoods = new List<string> { "pizza", "corn", "chicken" };


            //     if(favFoods.Contains("pizza")== true)
            //     {
            //         Console.WriteLine("\ntime to eat\n");
            //     }else
            //     {
            //         Console.WriteLine("\nIm hungry\n");
            //     }

            // List<int> numList = new List<int> { 1, 23, 9, 77, 922, 23, 32, 63, 14, 5 };

            // if (numList.Contains(23))
            // {
            //     numList.Remove(23);
            // }
            // if (numList.Contains(77))
            // {
            //     numList.Remove(77);
            // }

            // if (numList.Contains(6))
            // {
            //     numList.Remove(6);
            // }

            // if (numList.Contains(32))
            // {
            //     numList.Remove(32);
            // }
            // if (numList.Contains(6))
            // {
            //     numList.Remove(6);
            // }

            // if (numList.Contains(15))
            // {
            //     Console.WriteLine("true\n");
            // }
            // else
            // {
            //     Console.WriteLine("false\n");
            // }
            // if (numList.Contains(23))
            // {
            //     Console.WriteLine("true\n");
            // }
            // else
            // {
            //     Console.WriteLine("false\n");
            // }
            // if (numList.Contains(77))
            // {
            //     Console.WriteLine("true\n");
            // }
            // else
            // {
            //     Console.WriteLine("false\n");
            // }

            //     for (int i = 0; i < numList.Count; i++)
            // {
            //     Console.Write("{0} ", numList[i]);
            // }

            List<string> useMovie = new List<string> { "ALIENS", "MATRIX", "KILL BILL", "REACHER" };
            List<string> moviesOrdered = new List<string>();
            string enterAnother = "YES";
            while (enterAnother == "YES")
            {

                Console.Write("Please enter a movie you would like to rent or no to exit: ");
                string UserChoice = Console.ReadLine().ToUpper();
                exitMethod(UserChoice);
                if (useMovie.Contains(UserChoice) == true)
                {
                    Console.WriteLine("The movie is on the way");
                }

                else if (useMovie.Contains(UserChoice) == false)
                {
                    useMovie.Add(UserChoice);
                    moviesOrdered.Add(UserChoice);
                    Console.WriteLine("Your movie has been added and will be delivered shortly");
                }


                Console.WriteLine("Would you like to check out another movie : ");
                enterAnother = Console.ReadLine().ToUpper();
                
            }

            if (enterAnother == "NO")
                {

                    Console.Write("The following movies have been ordered: ");
                if(moviesOrdered.Count == 0)
                {
                    Console.WriteLine("You didnt order any movies");
                }else
                {
                    for (int i = 0; i < moviesOrdered.Count; i++)
                    {
                        Console.Write("{0}\n", moviesOrdered[i]);
                    }
                }
                    

                    System.Environment.Exit(1);

                }

            

        }

        public static void exitMethod(string exitStr)
        {
            if (exitStr == "NO")
            {
                System.Environment.Exit(1);
            }
        }
}
}
