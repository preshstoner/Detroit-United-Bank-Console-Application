using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DetroitUnitedBank;    

namespace DetroitUnitedBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = null;

            while (true)
            {
                Console.WriteLine("\nCommands: open | account | quit"); 
                Console.Write("Enter command: ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "open":
                        Console.Write("Enter name: ");
                        String name = Console.ReadLine();
                        Console.Write("Enter age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter address: ");
                        String address = Console.ReadLine();
                        Console.Write("Enter starting balance: ");
                        decimal balance = decimal.Parse(Console.ReadLine());

                        customer = new Customer(name, age, address, balance);
                        Console.WriteLine("Account opened successfully.");
                        break;

                    case "account":
                        if (customer == null)
                        {
                            Console.WriteLine("No account found. Please open an account first.");
                            break;
                        }

                        AccountMenu(customer);
                        break;  

                    case "quit":
                        Console.WriteLine("Exiting program.");
                        return;
                    default: 
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }

        static void AccountMenu(Customer customer)
        {
            while (true)
            {
                Console.WriteLine("\nCommands: deposit | withdraw | change | display | exit");
                Console.Write("Enter transaction command: ");
                string action = Console.ReadLine().ToLower();

                switch (action)
                {
                    case "deposit":
                        Console.Write("Enter deposit amount: ");
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        customer.Deposit(deposit);
                        break;

                    case "withdraw":
                        Console.Write("Enter withdrawal amount: ");
                        decimal withdraw = decimal.Parse(Console.ReadLine());
                        customer.Withdraw(withdraw);
                        break;

                    case "change":
                        Console.Write("Enter new name: ");
                        string newName = Console.ReadLine();
                        customer.ChangeName(newName);
                        break;

                    case "display":
                        customer.DisplayAccount();
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Invalid transaction command.");
                        break;
                }
            }
            {
                
            }
        }
    }
}
