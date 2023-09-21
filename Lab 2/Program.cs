using System;

public partial class Customer
{
    private static int customerCount = 0; // Статическое поле для подсчета созданных объектов

    private readonly int ID; // Поле только для чтения
    private const string DefaultAddress = "Не указан";

    // Поля класса
    private string lastName;
    private string firstName;
    private string patronymic;
    private string address;
    private long creditCardNumber;
    private decimal balance;

    // Конструктор по умолчанию
    public Customer()
    {
        ID = GetHashCode();
        customerCount++;
    }

    // Конструктор с параметрами
    public Customer(string lastName, string firstName, string patronymic, string address, long creditCardNumber, decimal balance)
        : this()
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.patronymic = patronymic;
        this.address = address;
        this.creditCardNumber = creditCardNumber;
        this.balance = balance;
    }

    // Статический конструктор (конструктор типа)
    static Customer()
    {
        Console.WriteLine("Вызван статический конструктор Customer.");
    }

    // Закрытый конструктор
    private Customer(string lastName, string firstName, string patronymic)
        : this()
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.patronymic = patronymic;
    }

    // Свойства
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string Patronymic
    {
        get { return patronymic; }
        set { patronymic = value; }
    }

    public string Address
    {
        get { return address ?? DefaultAddress; } // Если адрес не указан, возвращаем "Не указан"
        set { address = value; }
    }

    public long CreditCardNumber
    {
        get { return creditCardNumber; }
        set { creditCardNumber = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Метод для зачисления средств на счет
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Метод для списания средств со счета
    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    // Статический метод для вывода информации о классе
    public static void PrintClassInfo()
    {
        Console.WriteLine($"Класс Customer. Всего создано объектов: {customerCount}");
    }

    // Переопределение методов класса Object
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Customer))
            return false;

        Customer other = (Customer)obj;
        return ID == other.ID;
    }

    public override int GetHashCode()
    {
        return Guid.NewGuid().GetHashCode();
    }

    public override string ToString()
    {
        return $"ID: {ID}, ФИО: {LastName} {FirstName} {Patronymic}, Адрес: {Address}, Номер карты: {CreditCardNumber}, Баланс: {Balance:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer.PrintClassInfo(); // Вывод информации о классе

        // Создаем несколько объектов Customer
        Customer customer1 = new Customer("Иванов", "Иван", "Иванович", "ул. Пушкина, 1", 1234567890123456, 1000.50m);
        Customer customer2 = new Customer("Петров", "Петр", "Петрович", "ул. Ленина, 2", 9876543210987654, 1500.75m);
        Customer customer3 = new Customer("Сидоров", "Сидор", "Сидорович", "ул. Гагарина, 3", 1111222233334444, 750.25m);

        // Создаем массив объектов Customer
        Customer[] customers = new Customer[] { customer1, customer2, customer3 };

        // a) Вывод списка покупателей в алфавитном порядке
        Console.WriteLine("Список покупателей в алфавитном порядке:");
        Array.Sort(customers, (c1, c2) => string.Compare(c1.LastName, c2.LastName));
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.ToString());
        }

        // b) Вывод списка покупателей с номерами кредитных карт в заданном интервале
        long minCardNumber = 1000000000000000;
        long maxCardNumber = 9999999999999999;
        Console.WriteLine($"\nСписок покупателей с номерами кредитных карт в интервале от {minCardNumber} до {maxCardNumber}:");
        foreach (Customer customer in customers)
        {
            if (customer.CreditCardNumber >= minCardNumber && customer.CreditCardNumber <= maxCardNumber)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}
