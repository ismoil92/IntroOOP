using IntroOOP.Task1;
using IntroOOP;

static void Print(AccountBank accountBank) => Console.WriteLine($"Номер счёта:{accountBank.GetAccountNumber()}," +
    $"Баланс:{accountBank.GetBalance()}, Тип номер счёта:{accountBank.GetBankTypeAccount()}");

static void Task1()
{
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

    Print(account1);
    Console.WriteLine();
    Print(account2);
}


Task1();



