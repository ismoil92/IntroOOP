namespace IntroOOP.Task1;

public class AccountBank
{
    private int accountNumber; //Номер счёта
    private int balance;   // Баланс


    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="accountNumber">номер счёта</param>
    /// <param name="balance">баланс</param>
    public AccountBank(int accountNumber, int balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }




    /// <summary>
    /// Перегрузка оператора ==, для сравнение двух счёт в банках
    /// </summary>
    /// <param name="acc1">первый счёт банка</param>
    /// <param name="acc2">второй счёт банка</param>
    /// <returns>возвращает true, если они равны, false если они не равны</returns>
    public static bool operator == (AccountBank acc1, AccountBank acc2) => Equals(acc1, acc2);



    /// <summary>
    /// Перегрузка оператора !=, для сравнение двух счёт в банках
    /// </summary>
    /// <param name="acc1">первый счёт банка</param>
    /// <param name="acc2">второй счёт банка</param>
    /// <returns>возвращает true, если они не равны, false если они равны</returns>
    public static bool operator !=(AccountBank acc1, AccountBank acc2) => !(acc1==acc2);




    /// <summary>
    /// Переопределение метода Equals, для эквивалентности
    /// </summary>
    /// <param name="obj">объект с которым сравнывается</param>
    /// <returns>возвращает true, если они эквивалентны, false если они не эквивалентны</returns>
    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        if(obj.GetType() != typeof(AccountBank)) return false;
        AccountBank acc = (AccountBank)obj;
        return this.accountNumber == acc.accountNumber && this.balance == acc.balance;
    }


    /// <summary>
    /// Переопределение метода GetHashCode, для получение хеш-кода
    /// </summary>
    /// <returns>возвращает хеш-код</returns>
    public override int GetHashCode()
    {
        int hash = 397;
        unchecked
        {
            hash = (hash * 0x18d) ^ accountNumber.GetHashCode();
            hash = (hash * 0x18d) ^ balance.GetHashCode();
        }
        return hash;
    }

    /// <summary>
    /// Переопределение метода ToString, для формата вывода строки
    /// </summary>
    /// <returns>возвращает формат вывода строки</returns>
    public override string ToString() => $"Номер счёта:{accountNumber}, баланс:{balance}";
}