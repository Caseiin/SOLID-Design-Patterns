using System;

namespace OOP_Tutorials;

public class BankAccount
{
    private decimal balance;
    public decimal Balance => balance;

    public BankAccount(decimal amount)
    {
        Deposit(amount);
    }

    public void Deposit(decimal newAmount)
    {
        if(newAmount <= 0)
        {
            throw new ArgumentException("Deposited Amount must be positive");
        } 

        this.balance += newAmount;
    }

    public void WithDraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw Amount must be positive");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        this.balance -= amount;
    }
}

/* This class makes use of the Encapsulation OOP principle which ensures internal implementation is hidden and only
necessary data can be viewed externally. This adds security and control for the program. And prevents direct access from Client */
