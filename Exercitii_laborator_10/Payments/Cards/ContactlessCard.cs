using System;
using Exercitii_laborator_10.Interfaces;


namespace Exercitii_laborator_10.Payments.Cards
{
    class ContactlessCard : ClassicCard, IContactLessPay
    {
        public void TouchTheSensor()
        {
            Console.WriteLine("Se conecteaza...");
        }
    }
}
