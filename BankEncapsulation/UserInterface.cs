namespace BankEncapsulation;

public class UserInterface
{
    public static void MainMenu()
    {
        var myAccount = new BankAccount();
        string userInput = null;
        while (userInput != "exit")
        {
            Console.WriteLine("Please make a selection.");
            userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "deposit":
                    Console.WriteLine("How much would you like to deposit");
                    myAccount.Deposit(UserInputParse());
                    break;
                case "withdrawal":
                    Console.WriteLine("How much would you like to withdrawal?");
                    myAccount.Withdrawal(UserInputParse());
                    break;
                case "check balance":
                    Console.WriteLine($"You current balance is ${myAccount.GetBalance()}");
                    break;
                case "exit":
                    Console.WriteLine("Thank you for using our services!");
                    break;
                default:
                    Console.WriteLine("Unhandled exception\nPlease write a valid command:\nDeposit\nWithdrawal\nCheck balance\nExit");
                break;
            }
        }
    }
    public static double UserInputParse()
    {
        double? choiceOut = null;
        var inputSuccess = double.TryParse(Console.ReadLine(), out double parseSucceed);

        while (!inputSuccess)
        {
            Console.WriteLine("Please enter a cash number.");
            inputSuccess = double.TryParse(Console.ReadLine(), out parseSucceed);
        }

        choiceOut = parseSucceed;
        return (double)choiceOut;

    }
}