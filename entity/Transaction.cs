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

        public int AccountId { get; set; }
        public int Debit { get; set; }
        public int Kredit { get; set; }
        public int Saldo { get; set; }
        public string Date { get; set; }
    }
}