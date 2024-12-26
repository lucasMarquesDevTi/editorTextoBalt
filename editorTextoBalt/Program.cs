using System;

namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args) 
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1- Abrir");
            Console.WriteLine("2- Editar");
            Console.WriteLine("0- Sair");

            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir() { }

        static void Editar() 
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("---------------------------------");

            string texto = "";

            while (Console.ReadKey().Key != ConsoleKey.Escape) 
            { 

            }
        }
    }
}
