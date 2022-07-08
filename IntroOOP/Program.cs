using IntroOOP.Task1;

/// <summary>
/// Задача номер 1.
/// </summary>
static void Task1()
{
    Console.WriteLine("========   Задача номер 1 ======================");
    Console.WriteLine("=================================================");
    Console.WriteLine();
    AccountBank account1 = new() { AccountNumber = 111222333, Balance = 100000, BankTypeAccount = BankTypeAccount.Credit };
    AccountBank account2 = new() { AccountNumber = 222333111, Balance = 200000, BankTypeAccount = BankTypeAccount.Deposit };
    Console.Write("Введите сумму для снятия денег в банке на счету:");
    int money = int.Parse(Console.ReadLine()!);
    if(account1.TransferMoney(ref account2, money))
    {
        Console.WriteLine("Перевод успешно проведено!!");
    }
    else
    {
        Console.WriteLine("Сумма который вы хотите снять больше чем сумма в банке");
    }
}


/// <summary>
/// Задача номер 2.
/// </summary>
static void Task2()
{
    Console.WriteLine("========   Задача номер 2 ======================");
    Console.WriteLine("=================================================");
    Console.WriteLine();

    Console.Write("Введите слов:");
    string text = Console.ReadLine()!;
    bool palyndrom;
    string result =AccountBank.Reverse(text, out palyndrom);
    if (palyndrom)
    {
        Console.WriteLine($"Слово является палиндромом, Результат, слово буквы обратном порядке:{result}");
    }
    else
    {
        Console.WriteLine($"Слово не является палиндромом, Результат, слово буквы обратном порядке:{result}");
    }
}


/// <summary>
/// Задача номер 3.
/// </summary>
static void Task3()
{
    Console.WriteLine("========   Задача номер 3 ======================");
    Console.WriteLine("=================================================");
    Console.WriteLine();



    AccountBank.WriteFile();
    Console.WriteLine("Запись на новый файл записан !!!");
}

Task3();