using System;
using System.Runtime.CompilerServices;
namespace Tryin
{
    class Program
    {

        public static void Main(string[] args) 
        {
            string? n, g, o, h;
            int a, number;
            List<Parent> parent = new List<Parent>();
            List<Sibling> sibling = new List<Sibling>();


            Console.WriteLine("BEGIN? ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("What's your name?: ");
            n = Console.ReadLine();
            Console.Write("How old are you?: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Classification of gender?: ");
            g = Console.ReadLine();
            User user = new User(n, g, a);

            Console.WriteLine("");
            Console.WriteLine("READY?");
            Console.ReadLine();
            Console.WriteLine("Enter Parent Info: \n");

            Console.Write("Mothers name?: ");
            n = Console.ReadLine();
            Console.Write("How old is she?: (please input ZERO number if none)");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is her occupation?: ");
            o = Console.ReadLine();
            Parent mother = new Parent(n, o, a);
            parent.Add(mother);

            Console.WriteLine("");

            Console.Write("Fathers name?: ");
            n = Console.ReadLine();
            Console.Write("How old is he?: (please input ZERO number if none)");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is his occupation?: ");
            o = Console.ReadLine();
            Parent father = new Parent(n, o, a);
            parent.Add(father);

            Console.WriteLine("");
            Console.Write("Sibling Info: \nPress ENTER to proceed: \n");
            Console.ReadLine();

            Console.Write("The number of sibling you have?: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter sibling {i + 1} name?: ");
                n = Console.ReadLine();
                Console.Write("Enter age?: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter gender?: ");
                g = Console.ReadLine();
                Console.Write("Main Hobby?: ");
                h = Console.ReadLine();
                Sibling Sibling = new Sibling(n, g, h, a);
                sibling.Add(Sibling);

                Console.ReadLine();
            }

            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \n");
            Console.WriteLine($"Greetings! current user {user.n}, you are classified as {user.g} and on the age of {user.a}.\n");
            Console.WriteLine("Press ENTER to proceed.");
            Console.ReadLine();

            foreach (var item in parent)
            {
                Console.WriteLine("PARENT INFORMATION: ");
                Console.ReadLine();
                Console.WriteLine($"Name of Parent: {item.n}\n Age: {item.a}\n Current occupation: {item.o}");
                Console.WriteLine("");
            }
            Console.ReadLine();
            foreach (var item in sibling)
            {
                Console.WriteLine("SIBLING INFORMATION: ");
                Console.ReadLine();
                Console.WriteLine($"Sibling name: {item.n}\n Age: {item.a}\n Hobby: {item.h}");
                Console.WriteLine("");
            }

            Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("END");
            Console.ReadKey();
        }   
    }

    class User
    {
        public string? n, g;
        public int a;

        public User(string? n, string? g, int a)
        {
            this.n = n;
            this.g = g;
            this.a = a;
        }
    }
}