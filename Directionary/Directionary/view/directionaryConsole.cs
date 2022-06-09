using controller;
using System;
using System.Collections;
namespace view
{
    public class directionaryConsole
    {
        IDictionary Dictionary = new Hashtable();

        public static void Main(string[] args)
        {
            directionaryConsole console=new directionaryConsole();
            console.Menu();
        }
        public void Menu()
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
                            Update();
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
            Dictionary.Add(keys, values);
            Console.WriteLine("Success");
        }
        public void Search()
        {
            Console.WriteLine("Enter Dictionary:");
            string keys = Console.ReadLine();

            if (Dictionary.Contains(keys))
            {
                Console.WriteLine("There is a word named: " + keys + " in the Dictionary");
            }
            else
            {
                Console.WriteLine("That word does not exist");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter Dictionary:");
            string keys = Console.ReadLine();
            if (Dictionary.Contains(keys))
            {
                Dictionary.Remove(keys);
                Console.WriteLine("Deleted successfully");
            }
            else
            {
                Console.WriteLine("Deleted unsucessfully");
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter Key:");
            string keys= Console.ReadLine();
            
            if (Dictionary.Contains(keys))
            {
                Console.WriteLine("Enter value:");
                string value = Console.ReadLine();
                Dictionary[value] = value;
                Console.WriteLine("Updated successfully");
            }
            else
            {
                Console.WriteLine("Can not found!!!");
            }
        }
    }
}