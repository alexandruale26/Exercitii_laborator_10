using System;
using System.Text;
using Exercitii_laborator_10.Interfaces;
using Exercitii_laborator_10.Extensions;

namespace Exercitii_laborator_10.Register
{
    class CashRegister : IEssentials, IReceipt
    {
        private readonly Safe safe;
        public POS POS { get; private set; }
        public double CashRegisterTotal { get; set; }
        public StringBuilder Receipt { get; set; }
        public double BasketTotal { get; set; } = 0.0d;


        public CashRegister()
        {
            this.safe = new Safe();
            this.POS = new POS(this);
            this.Receipt = new StringBuilder();
        }


        public void Scan(Basket basket)
        {
            BasketTotal = 0.0d;

            if (basket.products.Count == 0)
            {
                Console.WriteLine("Cosul este gol");
                return;
            }

            foreach (var product in basket.products)
            {
                BasketTotal += product.Price;
            }

            CreateReceipt(basket);
            Console.WriteLine($"Total de plata {BasketTotal:N2} lei");
        }


        public double PayWithCash(double sumToPay)
        {
            if (sumToPay >= BasketTotal)
            {
                this.safe.Open();
                this.safe.InsertMoney(sumToPay);

                CashRegisterTotal += BasketTotal;

                Console.WriteLine($"Rest {(sumToPay - BasketTotal):N2} lei");
                this.safe.Close();

                Receipt.AppendLine($"Plata cash\nTotal {BasketTotal:N2} lei");
                PrintReceipt();

                return sumToPay - BasketTotal;
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
                Receipt.AppendLine(product.Description());
            }
        }


        private void PrintReceipt()
        {
            Console.WriteLine($"\n{Receipt}");
        }
    }
}
