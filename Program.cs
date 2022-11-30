Account ac = new Account(2);
ac.Deposit(20);
ac.Withdraw(10);

//account balances 
//1 - stan 2- current 3- extended
Console.WriteLine($"Standard account balance: {ac.GetBalance(1)}");
Console.WriteLine($"Current account balance: {ac.GetBalance(2)}");
Console.WriteLine($"Extended account balance: {ac.GetBalance(3)}");