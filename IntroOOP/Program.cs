using IntroOOP.Task1;


Task1();


/// <summary>
/// Задача номер один
/// </summary>
static void Task1()
{
    Console.WriteLine("========================Задача номер 1 ======================");
    Console.WriteLine("=============================================================");
    Console.WriteLine();
    AccountBank account1 = new(111222333, 150000);
    AccountBank account2 = new(333222444, 200000);

    bool istrue1 = account1 == account2;
    bool istrue2 = account1 != account2;
    bool istrue3 = account1.Equals(account2);

    int hash1 = account1.GetHashCode();
    int hash2 = account2.GetHashCode();

    Console.WriteLine(account1);
    Console.WriteLine(account2);
}