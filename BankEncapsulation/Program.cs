namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Deposit amount");

            var amountOfDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountOfDeposit);

            Console.WriteLine($"Your balance is now {account.GetBalance(amountOfDeposit)}.");
        }
    }
}
