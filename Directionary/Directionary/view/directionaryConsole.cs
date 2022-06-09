using controller;
using System;
using System.Collections;
namespace view
{
    public class directionaryConsole
    {
        IDictionary dictionary = new Hashtable();

        public static void Main(string[] args)
        {
            directionaryConsole console=new directionaryConsole();
            console.menu();
        }
        public void menu()
        {
            while (true) { 
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1.Add:");
            Console.WriteLine("2.Update:");
            Console.WriteLine("3.Delete:");
            Console.WriteLine("4.Search:");
            Console.WriteLine("5.Exit:");
            Console.WriteLine("Your choice:");

            int choice=Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            Add();
                            break;
                        case 2:
                            break;
                        case 3:
                            Delete();
                            break;
                        case 4:
                            Search();
                            break;
                        case 5:
                            Update();
                            break;
                        default:
                            Console.WriteLine("Enter number invalid");
                            break;
                    }
                }
                catch(Exception e) { Console.WriteLine(e); }
            }
        }
        public void Add()
        {
            Console.WriteLine("Enter key:");
            string keys=Console.ReadLine();
            Console.WriteLine("Enter value:");
            string values=Console.ReadLine();
            if (keys.Equals(dictionary.Keys))
            {
                Console.WriteLine("Fail");
            }
            else
            {
                dictionary.Add(keys, values);
                Console.WriteLine("Success");
            }

        }
        public void Search()
        {
            Console.WriteLine("Enter Dictionary:");
            string keys = Console.ReadLine();

           for(int i= 0; i < dictionary.Count; i++)
            {
                if (keys.Equals(dictionary.Keys))
                {
                    Console.WriteLine(dictionary.Values);
                }
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter Dictionary:");
            string keys = Console.ReadLine();
            foreach (string key in dictionary.Keys)
            {
                if (keys.Equals(key))
                {
                    dictionary.Remove(keys);
                    Console.WriteLine("Delete success");
                }
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter Key:");
            string keys= Console.ReadLine();
            Console.WriteLine("Enter value:");
            string value=Console.ReadLine();
            if (keys.Equals(dictionary.Keys))
            {
                dictionary[keys] = value;

            }
            else
            {
                Console.WriteLine("Can not found!!!");
            }
        }
    }
}