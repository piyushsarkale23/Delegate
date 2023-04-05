using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Bank , bank class should set the initial balance using constructor. Bank class should have debit & credit methods.
// Credit → add amount in the balance & then print the updated balance
// Debit → debt the amt from the balance
//   If balance is zero → raise an event “No balance” (amt should not debit from account)
//   Balance is less than 3000 → raise an event “Low balance”
//(amount can be debit from account + message should be displayed

namespace ConsoleApp42
{
    public delegate void MyDelegate();

    public class Bank
    {

        public event MyDelegate Balis0; //event declaration
        public event MyDelegate Lowbal;
        public event MyDelegate validbal;

        private int initalbal;
        private int amt;

        public Bank(int initalbal)
        {
            this.initalbal = initalbal;
        }

        public void credit(int amt)
        {
            initalbal = amt + initalbal;

        }
        public void debit(int amt)
        {
            initalbal = initalbal - amt;

        }
        public void Display()
        {
            if ( initalbal < amt )
            {
                Balis0();
            }
            if (initalbal < 3000 )
            {
                Lowbal();
            }
            if (initalbal >= 4000)
            {
                validbal();
            }

        }
    }

    public class Program
    {

        static void Message1()
        {
            Console.WriteLine("No Balance");

        }
        static void Message2()
        {
            Console.WriteLine("low Balance");

        }
        static void Message3()
        {
            Console.WriteLine("Bank  Balance is valid");

        }

        static void Main(string[] args)
        {
            Bank bank = new Bank(1000);
            bank.Balis0 += new MyDelegate(Message1);
            bank.Lowbal += new MyDelegate(Message2);
            bank.validbal += new MyDelegate(Message3);
            bank.credit(50000);
            bank.debit(6000);

            bank.Display();

        }
    }
}