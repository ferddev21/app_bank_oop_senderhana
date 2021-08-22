using System;
using bank_oop_sederhana.service;
using bank_oop_sederhana.entity;

namespace bank_oop_sederhana.view
{
    public class ViewMenu
    {
        public static void MainMenu()
        {
            bool isCheck = true;

            while (isCheck)
            {
                var auth = AuthImplement.GetAll();
                var account = AccountImplement.FindById(auth[0].AuthIdAccount);

                System.Console.WriteLine($"ID [{account.Id}]");
                System.Console.WriteLine($"Halo {account.Username},Saldo Anda :Rp. {account.Saldo} ");
                System.Console.WriteLine("1. Menabung");
                System.Console.WriteLine("2. Tarik");
                System.Console.WriteLine("3. Riwayat");
                System.Console.WriteLine("4. Ganti Pin");
                System.Console.WriteLine("x. Logout");
                System.Console.WriteLine("-----------------");
                System.Console.Write("Pilih : ");
                string input = System.Console.ReadLine();
                System.Console.Clear();
                switch (input)
                {
                    case "1":
                        ViewTransaction.Saving(account.Id);
                        break;

                    case "2":
                        ViewTransaction.Withdrow(account.Id);
                        break;

                    case "3":
                        ViewTransaction.HistoryTransaction(account.Id);
                        break;

                    case "4":
                        ViewAccount.ChangePassword(account.Id);
                        break;

                    case "x":
                        isCheck = false;
                        ViewAuth.Logout();
                        break;

                    default:

                        break;
                }
            }
        }
    }
}