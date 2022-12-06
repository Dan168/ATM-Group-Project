Account ac = new Account(2);
ac.Deposit(20, 3);
ac.Withdraw(10, 1);

//account balances 
//1 - stan 2- current 3- extended
Console.WriteLine($"Standard account balance: {ac.GetBalance(1)}");
Console.WriteLine($"Current account balance: {ac.GetBalance(2)}");
Console.WriteLine($"Extended account balance: {ac.GetBalance(3)}");

//print the overdraft limit for current accounts 
CurrentAccount cc = new CurrentAccount(1);
Console.WriteLine($"Current account overdaft limit: {cc.GetOverdraftLimit()}");
ac.Withdraw(10, 1);
//ac.Transfer(1, 2, 20);


