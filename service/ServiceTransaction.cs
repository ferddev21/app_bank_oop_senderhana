using System;
using bank_oop_sederhana.entity;

namespace bank_oop_sederhana.service
{
    public class ServiceTransaction
    {
        public static bool Saving(Int32 accountId, string input)
        {
            int number;
            bool isSaving = true;

            if (Int32.TryParse(input, out number))
            {
                int nominal = Convert.ToInt32(input);
                var account = AccountImplement.FindById(accountId);

                //update saldo
                if (AccountImplement.UpdateSaldo(accountId, nominal, isSaving))
                {
                    //update history transaksi
                    return !TransactionImplement.Insert(account.Id, nominal, 0, account.Saldo);
                }
                return true;
            }

            if (input == "x")
            {
                return false;
            }

            return true;
        }

        public static bool Withdrow(Int32 accountId, string input)
        {
            int number;
            bool isSaving = false;

            if (Int32.TryParse(input, out number))
            {
                int nominal = Convert.ToInt32(input);
                var account = AccountImplement.FindById(accountId);

                //check sisa saldo
                if (account.Saldo < nominal)
                {
                    return true;
                }

                //update saldo
                if (AccountImplement.UpdateSaldo(accountId, nominal, isSaving))
                {
                    //update history transaksi
                    return !TransactionImplement.Insert(account.Id, 0, nominal, account.Saldo);
                }
                return true;
            }

            if (input == "x")
            {
                return false;
            }

            return true;
        }
    }
}