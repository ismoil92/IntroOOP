namespace IntroOOP.Task2;
public class AccountBankTask2
{
   private int balance;
   private BankTypeAccount bankTypeAccount;
   private static int _accountNumber=111222333;

    /// <summary>
    /// Метод, для записи баланса
    /// </summary>
    /// <param name="balance">баланс в банке</param>
    public void SetBalance(int balance)=> this.balance = balance;

    /// <summary>
    /// Метод, для чтение баланса
    /// </summary>
    /// <returns>вернёт баланс банка</returns>
    public int GetBalance() => balance;


    /// <summary>
    /// Метод, для записи тип счёта номера
    /// </summary>
    /// <param name="bankTypeAccount">тип счёт номера банка</param>
    public void SetBankTypeAccount(BankTypeAccount bankTypeAccount) => this.bankTypeAccount = bankTypeAccount;

    /// <summary>
    /// Метод, для чтение тип счёта номера
    /// </summary>
    /// <returns>возвращает тип счёта номера в банке</returns>
    public BankTypeAccount GetBankTypeAccount() => bankTypeAccount;

    
    /// <summary>
    /// Метод, для записи счёт номера банка
    /// </summary>
    public static void SetAccountNumber() => _accountNumber++;

    /// <summary>
    /// Метод, для чтение счёт номера банка
    /// </summary>
    /// <returns>возвращает счёт номера банка</returns>
    public static int GetAccountNumber() => _accountNumber;
}
