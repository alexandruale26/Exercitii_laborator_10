using System;
using Exercitii_laborator_10.Interfaces;


namespace Exercitii_laborator_10.Payments.Smartphone
{
    class Smartphone : IContactLessPay
    {
        public void TouchTheSensor()
        {
            Console.WriteLine("Se conecteaza telefonul");
        }

        public void Pay()
        {
            Console.WriteLine("Plata a fost efectuata");
        }
    }
}
