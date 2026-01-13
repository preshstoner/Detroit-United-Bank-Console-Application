using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DetroitUnitedBank;

namespace DetroitUnitedBank
{
    public class Customer
    {

        public string Name;
        public int Age;
        public string Address;
        public decimal Balance;
        public int Transactions; 

        public Customer(string name, int age, string address, decimal startingBalance)
        {
            Name = name;
            Age = age;
            Address = address;
            Balance = startingBalance;
            Transactions = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions++;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
            else
            {
                Balance -= amount;
                Transactions++;
                Console.WriteLine($"Withdrew ${amount}. New balance: ${Balance}");
            }
        }

        public void ChangeName (string newName)
        {
            Name = newName;
            Console.WriteLine($"Name changed to {Name}");
        }

        public void DisplayAccount()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}"); 
            Console.WriteLine($"Balance: ${Balance}, Transactions: {Transactions}");
        }
    }
}
