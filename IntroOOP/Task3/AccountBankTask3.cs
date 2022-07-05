namespace IntroOOP.Task3;

public class AccountBankTask3
{
    private int balance;
    private BankTypeAccount bankTypeAccount;
    private static int accountNumber = 111333222;

    public AccountBankTask3()
    {
        accountNumber++;
        balance = 0;
        bankTypeAccount = BankTypeAccount.Текущий;
    }

    public AccountBankTask3(int balance):this()
    {
        this.balance = balance;
    }

    public AccountBankTask3(BankTypeAccount bankType):this()
    {
        this.bankTypeAccount = bankType;
    }

    public AccountBankTask3(int balance, BankTypeAccount bankType):this()
    {
        this.balance = balance;
        this.bankTypeAccount = bankType;
    }

    public void Print() => Console.WriteLine($"Номер счёта:{accountNumber}, Баланс:{balance}," +
        $"Тип номер счёта:{bankTypeAccount}");
}
