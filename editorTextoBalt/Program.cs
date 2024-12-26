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
            Console.WriteLine("2- Criar");
            Console.WriteLine("0- Sair");

            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Criar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir() { }

        static void Criar() { }
    }
}
