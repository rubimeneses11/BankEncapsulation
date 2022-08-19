//create a new instance of the BankAccount class.
//Allow the user of the application to Deposit money and retrieve their balance through the console.

using BankEncapsulation;

var rubisAccount = new BankAccount();

Console.WriteLine($"How much would you like to deposit today?");

var amountToDeposit = double.Parse(Console.ReadLine());

rubisAccount.Deposit(amountToDeposit);

Console.WriteLine($"Thanks! Your balance is now: ${rubisAccount.GetBalance()}");