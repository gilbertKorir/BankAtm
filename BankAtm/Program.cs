using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void Options()
            {
                Console.WriteLine("please choose one of the option below");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Show balance");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
            }

            void Deposit(CardHolder currentuser)
            {
                Console.WriteLine("Welcome How much do you want to Deposit?");
                Double deposit = Double.Parse(Console.ReadLine());
                currentuser.setBalance(deposit);
                Console.WriteLine("Thank you your Balance is: " + currentuser.getBalance());

            }
            void withdraw(CardHolder currentuser)
            {
                Console.WriteLine("How much do you want to withdraw?");
                Double withdrawal = Double.Parse(Console.ReadLine());
                if(currentuser.getBalance() < withdrawal)
                {
                    Console.WriteLine("Insuficient Balance : (");
                }
                else
                {
                    currentuser.setBalance(currentuser.getBalance() - withdrawal);
                    Console.WriteLine("Thank you you are good to go");
                }

            }

            void Balance(CardHolder currentuser)
            {
                Console.WriteLine("Current balance is : " + currentuser.getBalance());
            }

            List<CardHolder> listCards = new List<CardHolder>();

            listCards.Add(new CardHolder("29904071", 2990, "John", "Paul", 25000.34));
            listCards.Add(new CardHolder("667780", 2991, "Boaz", "Ken", 10000.34));

            Console.WriteLine("Welcome to simple ATM");
            Console.WriteLine("Please Insert your Card Number");

            string debitCard = "";
            CardHolder currentUser;
          
            while(true)
            {
                try
                {
                    debitCard = Console.ReadLine();

                    currentUser = listCards.FirstOrDefault(a => a.cardNum == debitCard);
                    if(currentUser != null) { break; }
                    else { Console.WriteLine("Card Not recognized"); }
                }
                catch
                {
                    Console.WriteLine("Card Not recognized");
                }
            }

            Console.WriteLine("Enter your pin");
            int usrpin = 0;

            while(true)
            {
                try
                {
                    usrpin = int.Parse(Console.ReadLine());

                    if(currentUser.getPin() == usrpin) { break; }
                    else
                    {
                        Console.WriteLine("iNCORRECT pIN");
                    }
                }
                catch
                {
                    Console.WriteLine("iNCORRECT pIN");
                }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName() + ":)");
            int option = 0;

            do
            {
                Options();

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                { }
                    if (option == 1) { Deposit(currentUser); }
                    else if(option == 2) { Balance(currentUser); }
                    else if(option == 3) { withdraw(currentUser); }
                    else if(option == 4) { break; }
                    else { option = 0; }
            
                
            }
            while (option != 4);
                Console.WriteLine("Thank you and have a great Day :)");
            

        }
    }
}
