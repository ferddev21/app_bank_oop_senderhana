using System;
using bank_oop_sederhana.view;

namespace bank_oop_sederhana
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }

        private static void RunProgram()
        {
            ViewAuth.Login();
            ViewMenu.MainMenu();
        }

    }
}
