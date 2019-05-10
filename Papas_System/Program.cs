using Papas_System.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System
{
    public class Program
    {

        static void Main(string[] args)
        {

            Program prog = new Program();
            prog.Run();
        }
        void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
    public class Menu
    {
        Controller control = new Controller();
        public void Show()
        {
            bool active = true;
            do
            {
                ShowMenu();
                int input = GetUserInput();
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        control.Boardgame();
                        Console.ReadLine();
                        break;
                }
            } while (active);
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. tilføj brætspil");
        }
        private int GetUserInput()
        {
            Console.WriteLine();
            Console.Write("Vælg menupunkt: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int parsedInput);
            return parsedInput;

        }
    }
}
