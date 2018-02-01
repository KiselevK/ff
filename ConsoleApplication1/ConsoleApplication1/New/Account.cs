using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class Account
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public int Sum { get; set; }

        public Account(string _name, int _id)
        {
            Name = _name;
            Id = _id;
        }
    }



    class Transaction<T> where T : Account
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Sum {FromAccount.Id}: {FromAccount.Sum} \nSum {ToAccount.Id}: {ToAccount.Sum}");
            }
            else
            {
                Console.WriteLine($"error sum at {FromAccount.Name}");
            }
        }

    }

    class AccOperation
    {
        public void Op()
        {
             Account acc1 = new Account("Bob",1857) { Sum = 4500 };
            Account acc2 = new Account("Bill", 3453) { Sum = 5000 };
            Transaction<Account> transaction1 = new Transaction<Account>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 3900
            };
            transaction1.Execute();
        }

    }
}
