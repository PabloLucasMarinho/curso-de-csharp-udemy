using System.Globalization;
using Heranca.Entities;

//Account acc = new(1001, "Alex", 0.0);
//BusinessAccount bacc = new(1002, "Maria", 0.0, 500.0);

//// UPCASTING
//Account acc1 = bacc;
//Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
//Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

//// DOWNCASTING
//BusinessAccount acc4 = (BusinessAccount)acc2;
//acc4.Loan(100.0);

//// Dá erro em tempo de execução
//// BusinessAccount acc5 = (BusinessAccount)acc3;

//if (acc3 is BusinessAccount)
//{
//    BusinessAccount acc5 = (BusinessAccount)acc3;
//    acc5.Loan(200.0);
//    Console.WriteLine("Loan!");
//}

//if (acc3 is SavingsAccount)
//{
//    // SavingsAccount acc5 = (SavingsAccount)acc3;
//    SavingsAccount acc5 = acc3 as SavingsAccount;
//    acc5.UpdateBalance();
//    Console.WriteLine("Update!");
//}

//Account acc1 = new(1001, "Alex", 500.0);
//Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

//acc1.Withdraw(10.0);
//acc2.Withdraw(10.0);

//Console.WriteLine(acc1.Balance);
//Console.WriteLine(acc2.Balance);

List<Account> accounts = [];

accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
accounts.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double sum = 0;

foreach (Account account in accounts)
{
    sum += account.Balance;
}

Console.WriteLine($"Total balance: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");