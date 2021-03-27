﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccounts(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Bia", 500.00, 400.00));
            list.Add(new SavingsAccounts(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Ana", 500.00, 500.00));

            double sum = 0.0;

            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine($"Total Balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (Account account in list)
            {
                account.Withdraw(10.0);
            }

            foreach (Account account in list)
            {
                Console.WriteLine($"Update balance for account {account.Number}: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            
        }
    }
}
