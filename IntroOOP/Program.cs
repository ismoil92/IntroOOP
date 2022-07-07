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
    int money = int.Parse(Console.ReadLine());
    account1.TransferMoney(ref account2, money);
}

Task1();