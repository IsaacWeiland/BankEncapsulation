namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0.00;

    public void Deposit(double cashDeposit)
    {
        _balance += cashDeposit;
        Console.WriteLine($"You deposited ${cashDeposit}");
    }

    public void Withdrawal(double cashReturn)
    {
        if (_balance <= 0)
        {
            Console.WriteLine("You cannot withdrawal anymore money");
        }
        else
        {
            _balance -= cashReturn;
            Console.WriteLine($"You withdrew ${cashReturn}");
        }
    }

    public double GetBalance()
    {
        return _balance;
    }
}