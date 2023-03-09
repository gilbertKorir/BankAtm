using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAtm
{
  public class CardHolder
    {
       public string cardNum;
        public int pin;
        string firstName;
        string lastName;
        double balance;

       public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public int getPin()
        {
            return pin;
        }
        public string getFirstName() { 
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }
        public double getBalance()
        {
            return balance;
        }


        public string getCardNum() { 
        return cardNum;
        }
    public void setPin(int newPin)
        {
            pin =newPin;
        }

        public void setFirstName(string newFirstname)
        {
            firstName = newFirstname;
        }

        public void setCardNum(string newCard)
        {
            cardNum = newCard;
        }
        
        public void setLastName(string newLastname)
        {
            lastName = newLastname;
        }

        public void setBalance(double bal)
        {
            balance = bal;
        }
    }
}
