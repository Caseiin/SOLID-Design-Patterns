
using OOP_Tutorials;

// Encapsulation eg:
// ===========================================================================================================

BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine($"balance amount for account is: {bankAccount.Balance}");

bankAccount.WithDraw(20);
System.Console.WriteLine($"balance amount for account is: {bankAccount.Balance}");

bankAccount.Deposit(80);
System.Console.WriteLine($"balance amount for account is: {bankAccount.Balance}");

// ===========================================================================================================
// Abstraction eg:
// ===========================================================================================================

EmailService emailService = new EmailService();
emailService.SendEmail(); 

// ===========================================================================================================
// Inheritance eg:
// ===========================================================================================================

Car car = new Car("Toyota","Corolla",2017);
car.Start();
System.Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}");
car.Stop();

// ===========================================================================================================
