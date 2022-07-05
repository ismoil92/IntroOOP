namespace IntroOOP.Task4;
public class AccountBankTask4
{
    /// <summary>
    /// Свойство Номер счёта
    /// </summary>
    public int AccountNumber { get; set; }

    /// <summary>
    /// Свойство Баланс
    /// </summary>
    public int Balance { get; set; }

    /// <summary>
    /// Свойство Тип номера счёта
    /// </summary>
    public BankTypeAccount BankTypeAccount { get; set; }

    /// <summary>
    /// Метод, для вывода информации о клиента в банке
    /// </summary>
    public void Print() => Console.WriteLine($"Номер счёта:{AccountNumber}, Баланс:{Balance}," +
        $"Тип номер счёта:{BankTypeAccount}");
}
