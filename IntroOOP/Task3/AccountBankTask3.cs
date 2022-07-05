namespace IntroOOP.Task3;

public class AccountBankTask3
{
    private int balance;
    private BankTypeAccount bankTypeAccount;
    private static int accountNumber = 111333222;

    /// <summary>
    /// Конструктор по умолчанию, без параметров
    /// </summary>
    public AccountBankTask3()
    {
        accountNumber++;
        balance = 0;
        bankTypeAccount = BankTypeAccount.Текущий;
    }

    /// <summary>
    /// Конструктор с одним параметром баланс, который вызывает конструктор по умолчанию
    /// </summary>
    /// <param name="balance">баланс банка</param>
    public AccountBankTask3(int balance):this()
    {
        this.balance = balance;
    }

    /// <summary>
    /// Конструктор с одним параметром Тип номер счёта, который вызывает конструктор по умолчанию
    /// </summary>
    /// <param name="bankType">тип номер счёта</param>
    public AccountBankTask3(BankTypeAccount bankType):this()
    {
        this.bankTypeAccount = bankType;
    }

    /// <summary>
    /// Конструктор с двумя параметром баланс и Тип номер счёта, который вызывает конструктор по умолчанию
    /// </summary>
    /// <param name="balance">баланс</param>
    /// <param name="bankType">тип номер счёта</param>
    public AccountBankTask3(int balance, BankTypeAccount bankType):this()
    {
        this.balance = balance;
        this.bankTypeAccount = bankType;
    }

    /// <summary>
    /// Метод, для вывода информации
    /// </summary>
    public void Print() => Console.WriteLine($"Номер счёта:{accountNumber}, Баланс:{balance}," +
        $"Тип номер счёта:{bankTypeAccount}");
}
