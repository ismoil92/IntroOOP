namespace IntroOOP.Task1;
public class AccountBank
{
    private int accountNumber;
    private int balance;
    private BankTypeAccount bankTypeAccount;

    /// <summary>
    /// Метод, для записи номер счёта
    /// </summary>
    /// <param name="number">номер счёта</param>
    public void SetAccountNumber(int number)=> accountNumber = number;

    /// <summary>
    /// Метод,для чтение номера счёта
    /// </summary>
    /// <returns>возвращает номер счёта в банке</returns>
    public int GetAccountNumber() => accountNumber;

    /// <summary>
    /// Метод, для записи баланса
    /// </summary>
    /// <param name="balance">баланс</param>
    public void SetBalance(int balance) => this.balance = balance;

    /// <summary>
    /// Метод, для чтение баланса
    /// </summary>
    /// <returns>возвращает баланс счёта в банке</returns>
    public int GetBalance() => balance;

    /// <summary>
    /// Метод, для записи тип номера счёта
    /// </summary>
    /// <param name="bankTypeAccount">тип номер счёта</param>
    public void SetBankTypeAccount(BankTypeAccount bankTypeAccount) => this.bankTypeAccount = bankTypeAccount;

    /// <summary>
    /// Метод, для чтение тип номера счёта
    /// </summary>
    /// <returns>Возвращает тип номера счёта в банке</returns>
    public BankTypeAccount GetBankTypeAccount() => bankTypeAccount;
}
