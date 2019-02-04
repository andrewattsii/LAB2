using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_LAB_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;




            Console.WriteLine(">Hello user, whar are you in the mood for ?");
            Console.WriteLine("Here are your options :");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good food");



            action = Console.ReadLine();




            if (action == "Action" || action == "action" || action == "1")

            {
                Console.WriteLine("You should go stock car racing ! How many people are coming with you ?");
                string peopleCount = Console.ReadLine();
                if (peopleCount == "0")
                {
                    Console.WriteLine("If youre going by yourself I would just wear sneakers.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }

                else if (peopleCount == "1" || peopleCount == "2" || peopleCount == "3" || peopleCount == "4")
                {
                    Console.WriteLine("You should travel in a sedan.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else if (peopleCount == "5" || peopleCount == "6" || peopleCount == "7" || peopleCount == "8" || peopleCount == "9" || peopleCount == "10")
                {
                    Console.WriteLine("The more the better !You should travel in a VW bus.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();

                }
                else if (peopleCount == "11" || peopleCount == "12" || peopleCount == "13" || peopleCount == "14")
                {
                    Console.WriteLine("You should travel in an airplane !");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Im sorry I dont understand..... ");
                    Console.ReadLine();
                }

            }













            if (action == "Chill times" || action == "chill times" || action == "2")

            {
                Console.WriteLine("You should go hiking ! How many people are you bringing with you ?");
                string peopleCount = Console.ReadLine();
                if (peopleCount == "0")

                {
                    Console.WriteLine("If youre going by yourself I would just wear sneakers.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else if (peopleCount == "1" || peopleCount == "2" || peopleCount == "3" || peopleCount == "4")
                {
                    Console.WriteLine("You should travel in a sedan.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else if (peopleCount == "5" || peopleCount == "6" || peopleCount == "7" || peopleCount == "8" || peopleCount == "9" || peopleCount == "10")
                {
                    Console.WriteLine("The more the better !You should travel in a VW bus.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else if (peopleCount == "11" || peopleCount == "12" || peopleCount == "13" || peopleCount == "14")
                {
                    Console.WriteLine("You should travel in an airplane !");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Im sorry I dont understand..... ");
                    Console.ReadLine();
                }

            }













            if (action == "Danger" || action == "danger" || action == "3")
            {

                Console.WriteLine("Danger ? Wow! I knew I saw the fire in your eyes . How many poeple are you bringing with you ?");
                string peopleCount = Console.ReadLine();
                if (peopleCount == "0")
                {
                    Console.WriteLine("If youre going by yourself I would just wear sneakers.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();

                }
                else if (peopleCount == "1" || peopleCount == "2" || peopleCount == "3" || peopleCount == "4")
                {
                    Console.WriteLine("You should travel in a sedan.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();

                }
                else if (peopleCount == "5" || peopleCount == "6" || peopleCount == "7" || peopleCount == "8" || peopleCount == "9" || peopleCount == "10")
                {
                    Console.WriteLine("The more the better !You should travel in a VW bus.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();

                }
                else if (peopleCount == "11" || peopleCount == "12" || peopleCount == "13" || peopleCount == "14")
                {
                    Console.WriteLine("You should travel in an airplane !");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Im sorry I dont understand..... ");
                    Console.ReadLine();
                }
            }









            if (action == "Good Food" || action == "good food" || action == "4")

            {
                Console.WriteLine("Hey I dont blame you. Im hungry all the time. How many people are you bringing with you ?");
                string peopleCount = Console.ReadLine();
                if (peopleCount == "0")

                {
                    Console.WriteLine("If youre going by yourself I would just wear sneakers.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else if (peopleCount == "1" || peopleCount == "2" || peopleCount == "3" || peopleCount == "4")
                {
                    Console.WriteLine("You should travel in a sedan.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else if (peopleCount == "5" || peopleCount == "6" || peopleCount == "7" || peopleCount == "8" || peopleCount == "9" || peopleCount == "10")

                {
                    Console.WriteLine("The more the better !You should travel in a VW bus.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();

                }
                else if (peopleCount == "11" || peopleCount == "12" || peopleCount == "13" || peopleCount == "14")
                {
                    Console.WriteLine("You should travel in an airplane !");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Im sorry I dont understand..... ");
                    Console.ReadLine();
                }

            }




        }
    }
}
