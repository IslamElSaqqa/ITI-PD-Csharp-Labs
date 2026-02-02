using System;
interface ITransactable
{
    void Deposit(double amount);
    void Withdraw(double amount);
}
interface IPrintable
{
    void PrintDetails();
}


abstract class Account : IPrintable, ITransactable
{
    private static int nextAccountNumber = 1000;

    private int accountNumber;
    private double balance;
    private string ownerName;

    protected Account(string ownerName, double initialBalance)
    {
        this.ownerName = ownerName;
        balance = initialBalance;
        accountNumber = nextAccountNumber++;
    }

    public int AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    public virtual void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
    }

    public abstract double CalculateInterest();

    protected void UpdateBalance(double amount)
    {
        balance += amount;
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Account #: {AccountNumber}");
        Console.WriteLine($"Owner: {OwnerName}");
        Console.WriteLine($"Balance: {Balance}");
    }
}

class SavingsAccount : Account
{
    private double interestRate;
    private double minimumBalance;

    public SavingsAccount(string owner, double balance, double rate)
        : base(owner, balance)
    {
        interestRate = rate;
        minimumBalance = 500;
    }

    public override double CalculateInterest()
    {
        return Balance * (interestRate / 100);
    }

    public void ApplyInterest()
    {
        UpdateBalance(CalculateInterest());
    }

    public override void Withdraw(double amount)
    {
        if (Balance - amount >= minimumBalance)
            base.Withdraw(amount);
        else
            Console.WriteLine("Cannot withdraw: Minimum balance required");
    }

    public override void PrintDetails()
    {
        Console.WriteLine("=== Savings Account ===");
        base.PrintDetails();
        Console.WriteLine($"Interest Rate: {interestRate}%");
    }
}


class CheckingAccount : Account
{
    private double overdraftLimit;
    private int freeTransactions;
    private int transactionCount;

    public CheckingAccount(string owner, double balance)
        : base(owner, balance)
    {
        overdraftLimit = 1000;
        freeTransactions = 3;
        transactionCount = 0;
    }

    public override double CalculateInterest()
    {
        return 0; 
    }

    public override void Withdraw(double amount)
    {
        if (Balance - amount >= -overdraftLimit)
        {
            UpdateBalance(-amount);
            transactionCount++;
        }
        else
            Console.WriteLine("Overdraft limit exceeded");
    }

    public override void PrintDetails()
    {
        Console.WriteLine("=== Checking Account ===");
        base.PrintDetails();
        Console.WriteLine($"Overdraft Limit: {overdraftLimit}");
        Console.WriteLine($"Transactions Used: {transactionCount}");
    }

    
}
