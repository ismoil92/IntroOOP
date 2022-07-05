using IntroOOP.Task1;
using IntroOOP.Task2;
using IntroOOP;

static void PrintTask1(AccountBank accountBank) => Console.WriteLine($"Номер счёта:{accountBank.GetAccountNumber()}," +
    $"Баланс:{accountBank.GetBalance()}, Тип номер счёта:{accountBank.GetBankTypeAccount()}");

static void PrintTask2(AccountBankTask2 account) => Console.WriteLine($"Номер счёта:{AccountBankTask2.GetAccountNumber()}," +
    $"Баланс:{account.GetBalance()}, Тип номер счёта:{account.GetBankTypeAccount()}");



/// <summary>
/// Домашняя работа номер 1.
/// </summary>
static void Task1()
{
    Console.WriteLine("Домашняя работа номер 1.");
    Console.WriteLine("===============================");
    Console.WriteLine();
    AccountBank account1 = new AccountBank();
    AccountBank account2 = new AccountBank();

    Console.Write("Введите номер счёта первого клиента:");
    account1.SetAccountNumber(Convert.ToInt32(Console.ReadLine()));
    Console.Write("Введите баланс первого клиента:");
    account1.SetBalance(Convert.ToInt32(Console.ReadLine()));
    account1.SetBankTypeAccount(BankTypeAccount.Кредитный);

    Console.WriteLine();
    Console.Write("Введите номер счёта второго клиента:");
    account2.SetAccountNumber(Convert.ToInt32(Console.ReadLine()));
    Console.Write("Введите баланс второго клиента:");
    account2.SetBalance(Convert.ToInt32(Console.ReadLine()));
    account2.SetBankTypeAccount(BankTypeAccount.Депозитный);

    PrintTask1(account1);
    Console.WriteLine();
    PrintTask1(account2);
}


/// <summary>
/// Домашняя работа номер 2.
/// </summary>
static void Task2()
{
    Console.WriteLine("Домашняя работа номер 2.");
    Console.WriteLine("===============================");
    Console.WriteLine();

    AccountBankTask2 account1 = new();
    AccountBankTask2 account2 = new();

    Console.Write("Введите баланс первого клиента:");
    account1.SetBalance(Convert.ToInt32(Console.ReadLine()));
    account1.SetBankTypeAccount(BankTypeAccount.Депозитный);
    AccountBankTask2.SetAccountNumber();

    PrintTask2(account1);

    Console.WriteLine();
    Console.Write("Введите баланс второго клиента:");
    account2.SetBalance(Convert.ToInt32(Console.ReadLine()));
    account2.SetBankTypeAccount(BankTypeAccount.Кредитный);
    AccountBankTask2.SetAccountNumber();

    Console.WriteLine();
    PrintTask2(account2);
}

Task2();
//Task1();



