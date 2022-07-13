using Exercitii_laborator_10.Interfaces;
using System;

namespace Exercitii_laborator_10.Register
{
    class POS
    {
        public IEssentials CashRegisterEssentials { get; private set; }


        public POS(IEssentials cashRegister)
        {
            this.CashRegisterEssentials = cashRegister;
        }


        public void PayContactFull(double sumToPay, IContactFullPay contactFull)
        {
            contactFull.InsertCard();
            contactFull.Pay();
            CashRegisterEssentials.CashRegisterTotal += CashRegisterEssentials.BasketTotal;
            contactFull.ExtractCard();

            CashRegisterEssentials.Receipt.AppendLine($"Plata Card Clasic\nTotal {CashRegisterEssentials.BasketTotal:N2} lei");

            PrintReceipt();
        }


        public void PayContactLess(double sumToPay, IContactLessPay contactLess)
        {
            contactLess.TouchTheSensor();
            contactLess.Pay();
            CashRegisterEssentials.CashRegisterTotal += CashRegisterEssentials.BasketTotal;

            CashRegisterEssentials.Receipt.AppendLine($"Plata Contactless\nTotal {CashRegisterEssentials.BasketTotal:N2} lei");

            PrintReceipt();
        }

        private void PrintReceipt()
        {
            Console.WriteLine($"\n{CashRegisterEssentials.Receipt}");
        }

    }
}
