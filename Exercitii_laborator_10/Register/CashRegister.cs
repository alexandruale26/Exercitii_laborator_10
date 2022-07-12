using System;
using System.Text;
using Exercitii_laborator_10.Interfaces;

namespace Exercitii_laborator_10.Register
{
    class CashRegister : IReceipt
    {
        private readonly Safe safe;
        public POS POS;
        public double CashRegisterTotal { get; set; }
        public StringBuilder Receipt { get; set; }

        public double basketTotal = 0.0d;


        public CashRegister()
        {
            this.safe = new Safe();
            this.POS = new POS(this);
            this.Receipt = new StringBuilder();
        }


        public void Scan(Basket basket)
        {
            basketTotal = 0.0d;

            if (basket.products.Count == 0)
            {
                Console.WriteLine("Cosul este gol");
                return;
            }

            foreach (var product in basket.products)
            {
                basketTotal += product.Price;
            }

            CreateReceipt(basket);
            Console.WriteLine($"Total de plata {basketTotal:N2} lei");
        }


        public double PayWithCash(double sumToPay)
        {
            if (sumToPay >= basketTotal)
            {
                this.safe.Open();
                this.safe.InsertMoney(sumToPay);

                CashRegisterTotal += basketTotal;

                Console.WriteLine($"Rest {(sumToPay - basketTotal):N2} lei");
                this.safe.Close();

                Receipt.AppendLine($"Plata cash\nTotal {basketTotal:N2} lei");
                PrintReceipt();

                return sumToPay - basketTotal;
            }
            Console.WriteLine("Nu aveti suficienti bani");
            return sumToPay;
        }


        public void CreateReceipt(Basket basket)
        {
            Receipt.Clear();

            Receipt.AppendLine("Bonul dumneavoastra");
            foreach (var product in basket.products)
            {
                Receipt.AppendLine(product.ToString());
            }
        }


        private void PrintReceipt()
        {
            Console.WriteLine($"\n{Receipt}");
        }
    }
}
