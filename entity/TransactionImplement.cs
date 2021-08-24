using System;
using System.Collections.Generic;

namespace bank_oop_sederhana.entity
{
    public class TransactionImplement : Transaction
    {
        public static List<Transaction> transaction = new List<Transaction>();
        public static bool Insert(int authId, int debit, int kredit, int saldo)
        {
            DateTime dateNow = DateTime.Now;

            transaction.Add(
             new Transaction(authId, debit, kredit, saldo, dateNow.ToString("g"))
            );
            return true;
        }
        public static List<Transaction> GetById(int authId)
        {
            for (int i = 0; i < transaction.Count; i++)
            {
                if (authId == transaction[i].AccountId)
                {
                    return transaction;
                }
            }

            return null;
        }

        public static List<Transaction> GetAll()
        {
            return transaction;
        }
    }
}