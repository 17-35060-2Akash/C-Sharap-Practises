namespace MyLibrary
{
    public class Account
    {
        private int accountNumber;
        public string accountName;
        protected string email;
        internal int voterId;
        protected internal string address;
        public Account()
        {
            System.Console.WriteLine("Account created..");
        }
    }
}
