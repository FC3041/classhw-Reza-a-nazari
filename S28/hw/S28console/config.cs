namespace config;

public abstract class CashDispenser
{
    protected CashDispenser _nextCashDis;

    public abstract int BankNoteUnit { get; }

    public void Setnext(CashDispenser cd)
    {
        _nextCashDis = cd;
    }
    public void Dispense(int amount)
    {
        if (amount % 5 != 0 && amount % 10 != 0 && amount % 20 != 0 && amount % 100 != 0)
        {
            System.Console.WriteLine("wait ...");
            Thread.Sleep(1000);
            System.Console.WriteLine("connect to Sepah Bank ...");
            Thread.Sleep(3000);
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("|                          |");
            System.Console.WriteLine("|  Pool Dar Atm nmibashad  |");
            System.Console.WriteLine("----------------------------");
            Environment.Exit(0);
        }
        int amount2dispense = amount / BankNoteUnit;
        if (amount2dispense > 0)
        {
            System.Console.WriteLine($" {BankNoteUnit}Dispenser: Here you are: {amount2dispense}");
        }

        amount2dispense = amount % BankNoteUnit;
        if (_nextCashDis != null)
        {
            if (amount2dispense > 0)
            {
                _nextCashDis.Dispense(amount2dispense);
            }
        }
        else if (amount2dispense > 0)
        {
            System.Console.WriteLine($" ERROR: Cannot dispense this amount: {amount}");
        }
    }
}


public class CashDispenser100 : CashDispenser
{
    public override int BankNoteUnit => 100;
}

public class CashDispenser50 : CashDispenser
{
    public override int BankNoteUnit => 50;
}



public class CashDispenser20 : CashDispenser
{
    public override int BankNoteUnit => 20;
}


public class CashDispenser10 : CashDispenser
{
    public override int BankNoteUnit => 10;
}


public class CashDispenser5 : CashDispenser
{
    public override int BankNoteUnit => 5;
}


public class MyP
{
    public static void Main(string[] args)
    {
        var cd100 = new CashDispenser100();
        var cd50 = new CashDispenser50();
        var cd20 = new CashDispenser20();
        var cd10 = new CashDispenser10();
        var cd5 = new CashDispenser5();

        cd100.Setnext(cd50);

        cd50.Setnext(cd20);

        cd20.Setnext(cd10);

        cd10.Setnext(cd5);

        cd100.Dispense(33655);
        System.Console.WriteLine();
        System.Console.WriteLine();

        cd100.Dispense(33654);


    }
}

