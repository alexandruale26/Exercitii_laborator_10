using System.Text;


namespace Exercitii_laborator_10.Interfaces
{
    interface IEssentials
    {
        StringBuilder Receipt { get; set; }
        double CashRegisterTotal { get; set; }
        double BasketTotal { get; set; }
    }
}
