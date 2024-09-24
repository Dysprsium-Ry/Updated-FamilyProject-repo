using System;
namespace Tryin
{
    class Program
    {

        public static void Main(string[] args)
        {
            string? n, g, o, h;
            int a, number;
            bool isValid = false;
            string? choices, ifValid;
            List<Parent> parent = new List<Parent>();
            List<Sibling> sibling = new List<Sibling>();


            Console.WriteLine("BEGIN? ");
            while (true)
            {
                var key = Console.ReadKey(true);  // true to not display the pressed key

                // If Enter is pressed, exit the loop
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Proceeding!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please do press ENTER key only.");
                }
            }
            Console.Clear();



            Console.Write("What's your name?: ");
            n = Console.ReadLine();
            while (true)
            {
                Console.Write("How old are you?: ");
                ifValid = Console.ReadLine();

                if (int.TryParse(ifValid, out a))
                {
                    break;
                }
                else { Console.WriteLine("Enter ONLY a NUMBER!!!"); }
            }
            Console.Write("Classification of gender?: ");
            g = Console.ReadLine();
            User user = new User(n, g, a);




            do
            {
                Console.WriteLine("");
                Console.WriteLine("READY?");
                while (true)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Proceeding!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Press only ENTER key.");
                    }
                }
                Console.Clear();




                Console.WriteLine("Enter Parent Info: \n");

                Console.Write("Mothers name: ");
                n = Console.ReadLine();
                Console.WriteLine("(please input ZERO number if none):");
                Console.Write("How old is she?: ");
                while (true)
                {
                    ifValid = Console.ReadLine();

                    if (int.TryParse(ifValid, out a))
                    {
                        break;
                    }
                    else { Console.WriteLine("Enter ONLY a NUMBER!!!"); }
                }
                Console.Write("What is her occupation?: ");
                o = Console.ReadLine();
                Parent mother = new Parent(n, o, a);
                parent.Add(mother);


                Console.WriteLine("");


                Console.Write("Fathers name: ");
                n = Console.ReadLine();
                Console.WriteLine("(please input ZERO number if none):");
                Console.Write("How old is he?: ");
                while (true)
                {
                    ifValid = Console.ReadLine();

                    if (int.TryParse(ifValid, out a))
                    {
                        break;
                    }
                    else { Console.WriteLine("Enter ONLY a NUMBER!!!"); }
                }
                Console.Write("What is his occupation?: ");
                o = Console.ReadLine();
                Parent father = new Parent(n, o, a);
                parent.Add(father);




                Console.WriteLine("");
                Console.Write("Sibling Info Input: \nPress ENTER to proceed: \n");
                while (true)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Proceeding!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Press only ENTER key.");
                    }
                }
                Console.Clear();




                while (true)
                {
                    Console.Write("The number of sibling?: ");
                    ifValid = Console.ReadLine();

                    if (int.TryParse(ifValid, out number))
                    {
                        break;
                    }
                    else { Console.WriteLine("Enter ONLY a NUMBER!!!"); }
                }
                Console.WriteLine("");

                for (int i = 0; i < number; i++)
                {
                    Console.Write($"Enter sibling {i + 1} name?: ");
                    n = Console.ReadLine();
                    while (true)
                    {
                        Console.Write("Enter age: ");
                        ifValid = Console.ReadLine();

                        if (int.TryParse(ifValid, out a))
                        {
                            break;
                        }
                        else { Console.WriteLine("Enter ONLY a NUMBER!!!"); }
                    }
                    Console.Write("Enter gender: ");
                    g = Console.ReadLine();
                    Console.Write("Main Hobby?: ");
                    h = Console.ReadLine();
                    Sibling Sibling = new Sibling(n, g, h, a);
                    sibling.Add(Sibling);

                    Console.WriteLine("");
                }

                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \n");
                Console.WriteLine($"Greetings! current user {user.n}, you are classified as {user.g} and on the age of {user.a}.\n");
                Console.WriteLine("Press ENTER to proceed.");
                while (true)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Proceeding!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Press only ENTER key.");
                    }
                }
                Console.Clear();
                Console.WriteLine("");


                foreach (var item in parent)
                {
                    Console.WriteLine("PARENT INFORMATION: ");
                    while (true)
                    {
                        var key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Proceeding!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Press only ENTER key.");
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"Name of Parent: {item.n}\n Age: {item.a}\n Current occupation: {item.o}");
                    Console.WriteLine("\n");
                }



                while (true)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Proceeding Sibling Info...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Press only ENTER key.");
                    }
                }
                Console.WriteLine("\n");



                foreach (var item in sibling)
                {
                    Console.WriteLine("SIBLING INFORMATION: ");
                    while (true)
                    {
                        var key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Press only ENTER key.");
                        }
                    }
                    Console.WriteLine($"Sibling name: {item.n}\n Age: {item.a}\n Gender: {item.g}\n Hobby: {item.h}");
                    Console.WriteLine("\n");
                }


                while (true)
                {
                    Console.WriteLine("Do you want to add more DATA? Y/N");
                    choices = Console.ReadLine();


                    if (choices?.ToUpper() == "Y")
                    {
                        isValid = true;
                        Console.Clear();
                        break;
                    }
                    else if (choices?.ToUpper() == "N")
                    {
                        isValid = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }

                parent.Clear();
                sibling.Clear();

            } while (isValid == true);

            Console.WriteLine("");
            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}