using System;
using bank_oop_sederhana.entity;

namespace bank_oop_sederhana.service
{
    public class ServiceTransaction
    {
        public static bool Saving(Int32 userId, string input)
        {
            int number;
            bool isSaving = true;

            if (Int32.TryParse(input, out number))
            {
                int nominal = Convert.ToInt32(input);
                var user = AccountImplement.FindById(userId);

                //update saldo
                if (AccountImplement.UpdateSaldo(userId, nominal, isSaving))
                {
                    //update history transaksi
                    return !TransactionImplement.Insert(user.Id, nominal, 0, user.Saldo);
                }
                return true;
            }

            if (input == "x")
            {
                return false;
            }

            return true;
        }

        public static bool Withdrow(Int32 userId, string input)
        {
            int number;
            bool isSaving = false;

            if (Int32.TryParse(input, out number))
            {
                int nominal = Convert.ToInt32(input);
                var user = AccountImplement.FindById(userId);

                //update saldo
                if (AccountImplement.UpdateSaldo(userId, nominal, isSaving))
                {
                    //update history transaksi
                    return !TransactionImplement.Insert(user.Id, 0, nominal, user.Saldo);
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