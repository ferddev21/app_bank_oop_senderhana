using System;
using bank_oop_sederhana.service;
using bank_oop_sederhana.entity;

namespace bank_oop_sederhana.view
{
    public class ViewMenu
    {

        private static bool check = true;
        public static void MainMenu()
        {
            while (check)
            {
                var auth = AuthImplement.GetAll();
                var user = AccountImplement.FindById(auth[0].AuthIdAccount);


                System.Console.Clear();
                System.Console.WriteLine($"Halo {user.Username},Saldo Anda : {user.Saldo} ");
                System.Console.WriteLine("1. Menabung");
                System.Console.WriteLine("2. Tarik");
                System.Console.WriteLine("3. Riwayat");
                System.Console.WriteLine("3. Ganti Pin");
                System.Console.WriteLine("-----------------");
                System.Console.Write("Pilih : ");
                string input = System.Console.ReadLine();
                System.Console.Clear();
                switch (input)
                {
                    case "1":
                        ViewTransaction.Saving();
                        check = true;
                        break;

                    case "2":
                        ViewTransaction.Saving();
                        check = true;
                        break;

                    default:
                        check = true;
                        break;
                }
            }
        }
    }
}