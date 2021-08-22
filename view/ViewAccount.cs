using System;
using bank_oop_sederhana.entity;

namespace bank_oop_sederhana.view
{
    public class ViewAccount
    {
        public static void ChangePassword(Int32 userId)
        {
            System.Console.WriteLine("Klik 'x' untuk kembali ke menu ");
            System.Console.WriteLine("-------------------------- ");
            System.Console.Write("Masukkan password baru : ");
            string input = System.Console.ReadLine();
            System.Console.Clear();
            if (input != "x")
            {
                if (AccountImplement.UpdatePassword(userId, input))
                {
                    System.Console.WriteLine("Password, Berhasil di ubah! ");
                }
                else
                {
                    System.Console.WriteLine("Password, Gagal di ubah! ");
                }
            }
        }
    }
}