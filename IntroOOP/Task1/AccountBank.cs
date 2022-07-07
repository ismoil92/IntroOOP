namespace IntroOOP.Task1;

public class AccountBank
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
    /// Тип банковского счёта
    /// </summary>
    public BankTypeAccount BankTypeAccount { get; set; }

    /// <summary>
    /// Метод, для перевода деньги с одного счета на другое
    /// </summary>
    /// <param name="account">счёт у которого будет сниматься деньги</param>
    /// <param name="money">сумма которое будет сниматься</param>
    /// <returns>возвращает true, если баланс больше чем сумма которое будет сниматься, false если баланс меньше чем сумма</returns>
    public bool TransferMoney(ref AccountBank account, int money)
    {
        if (account.Balance >= money)
        {
            this.Balance += money;
            account.Balance -= money;
            return true;
        }
        else
            return false;
    }
}

/// <summary>
/// Тип Банковского счёта, перечисление
/// </summary>
public enum BankTypeAccount
{
    Current,
    Estimated,
    Credit,
    Deposit
}