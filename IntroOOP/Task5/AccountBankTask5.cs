namespace IntroOOP.Task5;

public class AccountBankTask5
{
    /// <summary>
    /// Свойство Номер счёта
    /// </summary>
    public int AccountNumber { get; set; }

    /// <summary>
    /// Статический свойство баланс, который равен 100 000
    /// </summary>
    public static int Balance { get; set; } = 100000;

    /// <summary>
    /// Свойство Тип номер счёта
    /// </summary>
    public BankTypeAccount BankType { get; set; }


    /// <summary>
    /// Метод, для снятия со счёта
    /// </summary>
    /// <param name="takeOffMoney">сумма для снятия со счёта</param>
    /// <returns>Возвращает оставшиеся баланс счёта</returns>
    public static int TakeOffDeposite(int takeOffMoney)
    {
        if (Balance - takeOffMoney > 0)
        {
            Balance -= takeOffMoney;
            return Balance;
        }
        else
        {
            Console.WriteLine("Деньги который хотите снять больше чем депозит, введите корректный число!");
            return Balance;
        }
    }

    /// <summary>
    /// Метод для пополнение баланса депозита
    /// </summary>
    /// <param name="putMoney">сумма для пополнение баланса</param>
    /// <returns></returns>
    public static int PutDeposite(int putMoney)
    {
        Balance += putMoney;
        return Balance;
    }
}

