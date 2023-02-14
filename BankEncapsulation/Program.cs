using static BankEncapsulation.BankExercise;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myBank = new BankAccount();
            Console.WriteLine("enter amount you wish to deposite");
            var DepositeAmount = int.Parse(Console.ReadLine());
            myBank.Deposite(DepositeAmount);
            Console.WriteLine("Your balance is now:");
            Console.WriteLine(myBank.GetBalance());
        }
    }
}
