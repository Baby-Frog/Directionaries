using controller;
using System;
using System.Collections;
namespace view
{
    public class directionaryConsole
    {
        public static void Main(string[] args)
        {
            directionaryController directionaryCtrl = new directionaryController();
            Console.WriteLine("Enter new directionary:");
            Object directions=    Console.ReadLine();
            directionaryCtrl.AddDirect(directions);
        }
    }
}