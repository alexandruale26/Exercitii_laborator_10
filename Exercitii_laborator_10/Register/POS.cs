using Exercitii_laborator_10.Interfaces;
using System;

namespace Exercitii_laborator_10.Register
{
    class POS
    {
        public CashRegister CashRegister { get; private set; }


        public POS(CashRegister cashRegister)
        {
            this.CashRegister = cashRegister;
        }


        public void PayContactFull(double sumToPay, IContactFullPay contactFull)
        {
            contactFull.InsertCard();
            contactFull.Pay();
            CashRegister.CashRegisterTotal += CashRegister.basketTotal;
            contactFull.ExtractCard();

            CashRegister.Receipt.AppendLine($"Plata Card Clasic\nTotal {CashRegister.basketTotal:N2} lei");

            PrintReceipt();
        }


        public void PayContactLess(double sumToPay, IContactLessPay contactLess)
        {
            contactLess.TouchTheSensor();
            contactLess.Pay();
            CashRegister.CashRegisterTotal += CashRegister.basketTotal;

            CashRegister.Receipt.AppendLine($"Plata Contactless\nTotal {CashRegister.basketTotal:N2} lei");

            PrintReceipt();
        }

        private void PrintReceipt()
        {
            Console.WriteLine($"\n{CashRegister.Receipt}");
        }
    }
}
