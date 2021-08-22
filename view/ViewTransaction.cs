using System;
using bank_oop_sederhana.entity;
using bank_oop_sederhana.service;

namespace bank_oop_sederhana.view
{
    public class ViewTransaction
    {
        private static bool isCheck = true;
        public static void Saving(Int32 userId)
        {
            isCheck = true;

            while (isCheck)
            {
                System.Console.WriteLine("klik 'x' untuk batal");
                System.Console.WriteLine("Menabung");
                System.Console.WriteLine("-------------------");
                System.Console.Write("masukkan nominal yang mau disimpan: ");
                var input = System.Console.ReadLine();
                System.Console.Clear();

                isCheck = ServiceTransaction.Saving(userId, input);

            }

        }

        public static void Withdrow(Int32 userId)
        {
            isCheck = true;

            while (isCheck)
            {
                System.Console.Clear();
                System.Console.WriteLine("klik 'x' untuk batal");
                System.Console.WriteLine("Tarik tabungan");
                System.Console.WriteLine("-------------------");
                System.Console.Write("masukkan nominal yang mau ditarik: ");
                var input = System.Console.ReadLine();
                System.Console.Clear();

                isCheck = ServiceTransaction.Withdrow(userId, input);

            }
        }

        public static void HistoryTransaction(Int32 userId)
        {
            isCheck = true;

            while (isCheck)
            {
                System.Console.Clear();
                System.Console.WriteLine("klik 'x' untuk kembali ke menu");
                System.Console.WriteLine("-----------------------------------------");
                var transaction = TransactionImplement.GetById(userId);

                if (transaction != null)
                {
                    for (int i = 0; i < transaction.Count; i++)
                    {
                        if (transaction[i].AccountId == userId)
                        {
                            System.Console.WriteLine($"Tanggal Transaksi : {transaction[i].Date}");
                            System.Console.WriteLine($"Nomimal Masuk : Rp. {transaction[i].Debit}");
                            System.Console.WriteLine($"Nomimal Keluar :  Rp. {transaction[i].Kredit}");
                            System.Console.WriteLine();
                        }
                    }


                }
                else
                {
                    System.Console.WriteLine("Tidak Ada Data Riwayat");
                }

                System.Console.WriteLine("-----------------------------------------");
                var input = System.Console.ReadLine();
                System.Console.Clear();
                isCheck = (input == "x") ? false : true;

            }
        }
    }
}