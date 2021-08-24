namespace bank_oop_sederhana.entity
{
    public class Transaction
    {
        public Transaction()
        {
        }

        public Transaction(int accountId, int debit, int kredit, int saldo, string date)
        {
            AccountId = accountId;
            Debit = debit;
            Kredit = kredit;
            Saldo = saldo;
            Date = date;
        }

        public int AccountId { get; protected set; }
        public int Debit { get; protected set; }
        public int Kredit { get; protected set; }
        public int Saldo { get; protected set; }
        public string Date { get; protected set; }
    }
}