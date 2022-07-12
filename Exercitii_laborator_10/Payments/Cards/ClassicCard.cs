using System;
using Exercitii_laborator_10.Interfaces;


namespace Exercitii_laborator_10.Payments.Cards
{
    class ClassicCard : IContactFullPay
    {
        public void InsertCard()
        {
            Console.WriteLine("Card introdus");
        }


        public void Pay()
        {
            Console.WriteLine("Plata a fost efectuata");
        }


        public void ExtractCard()
        {
            Console.WriteLine("Card retras");
        }
    }
}
