using System;
using System.Collections.Generic;

namespace bank_oop_sederhana.entity
{
    public class AccountImplement : Account
    {
        private static List<Account> account = new List<Account>(){
                new Account(1,"ferdian","1234",10000),
                new Account(2,"arjun","1234",15000)
        };

        public static List<Account> GetAll()
        {
            return account;
        }

        public static Account FindById(int id)
        {
            Account result = account.Find(
                delegate (Account account)
                {
                    return account.Id == id;
                }
             );

            return result;

        }
        public static bool Save(string username, string password, int saldo)
        {
            account.Add(
                new Account(account.Count + 1, username, password, saldo)
            );
            return true;
        }

        public static bool UpdateSaldo(int userId, int nominal, bool isSaving)
        {
            for (int i = 0; i < account.Count; i++)
            {
                if (account[i].Id == userId)
                {
                    if (isSaving)
                    {
                        account[i].Saldo += nominal;

                    }
                    else
                    {
                        account[i].Saldo -= nominal;
                    }

                }
            }
            return true;
        }

        public static bool UpdatePassword(int userId, string password)
        {
            for (int i = 0; i < account.Count; i++)
            {
                if (account[i].Id == userId)
                {

                    account[i].Password = password;
                }
            }
            return true;
        }
    }
}