using IntroOOP.Task1;
using IntroOOP.Task2;
using IntroOOP.Task3;
using IntroOOP.Task4;
using IntroOOP.Task5;
using IntroOOP;


/// <summary>
/// Метод, для информации первого задачи
/// </summary>
/// <param name="accountBank"> Объект первого задачи</param>
static void PrintTask1(AccountBank accountBank) => Console.WriteLine($"Номер счёта:{accountBank.GetAccountNumber()}," +
$"Баланс:{accountBank.GetBalance()}, Тип номер счёта:{accountBank.GetBankTypeAccount()}");

/// <summary>
///  Метод, для информации второго задачи
/// </summary>
/// <param name="account">Объект второго задачи</param>
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
    AccountBank account1 = new ();
    AccountBank account2 = new ();

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

/// <summary>
/// Домашняя работа номер 3.
/// </summary>
static void Task3()
{
    Console.WriteLine("Домашняя работа номер 3.");
    Console.WriteLine("===============================");
    Console.WriteLine();

    AccountBankTask3 account1 = new ();
    account1.Print();
    Console.WriteLine();
    AccountBankTask3 account2 = new (100000);
    account2.Print();
    Console.WriteLine();
    AccountBankTask3 account3 = new (BankTypeAccount.Депозитный);
    account3.Print();
    Console.WriteLine();
    AccountBankTask3 account4 = new (150000, BankTypeAccount.Кредитный);
    account4.Print();
    Console.WriteLine();
}

/// <summary>
/// Домашняя работа номер 4.
/// </summary>
static void Task4()
{
    Console.WriteLine("Домашняя работа номер 4.");
    Console.WriteLine("===============================");
    Console.WriteLine();

    AccountBankTask4 account1 = new() { AccountNumber = 111222333, Balance = 100000, BankTypeAccount = BankTypeAccount.Расчётный };
    AccountBankTask4 account2 = new() { AccountNumber = 222333111, Balance = 150000, BankTypeAccount = BankTypeAccount.Депозитный };

    account1.Print();
    Console.WriteLine();
    account2.Print();
}


/// <summary>
/// Домашняя работа номер 5.
/// </summary>
static void Task5()
{
    Console.WriteLine("Домашняя работа номер 5.");
    Console.WriteLine("===============================");
    Console.WriteLine();
    Console.Write("Введите сумму для снятий денег:");
    int result = AccountBankTask5.TakeOffDeposite(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine(result);
}

/// <summary>
/// Метод, для выбора задач
/// </summary>
static void SelectTask()
{
    Console.WriteLine("Задача номер 1");
    Console.WriteLine("Задача номер 2");
    Console.WriteLine("Задача номер 3");
    Console.WriteLine("Задача номер 4");
    Console.WriteLine("Задача номер 5");
    Console.Write("Выберите задачу 1-5:");
    int numb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (numb)
    {
        case 1:
            Task1();
            break;
        case 2:
            Task2();
            break;
        case 3:
            Task3();
            break;
        case 4:
            Task4();
            break;
        case 5:
            Task5();
            break;
        default:
            Console.WriteLine("Введите число от 1 до 5 включительно");
            break;
    }
}


SelectTask();