using System;


namespace Exercitii_laborator_10.Register
{
    class Safe
    {
        private double totalCash = 0.0d;

        public void Open()
        {
            Console.WriteLine("Seiful a fost deschis");
        }


        public void InsertMoney(double sum)
        {
            this.totalCash += sum;
            Console.WriteLine("Suma a fost introdusa");
        }


        public void Close()
        {
            Console.WriteLine("Seiful a fost inchis");
        }
    }
}
