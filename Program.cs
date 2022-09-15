using System;

namespace Ref_VS_Out
{
    class Program
    {
        //BruttoSalary -kuu bruto
        //YearlySalary -aasta bruto
        //MonthlyTaxFree - maksuvaba tulu ühes kuus
        static void Main(string[] args)
        {

            Console.WriteLine("Insert brutto salary ");
            float BruttoSalary = float.Parse(Console.ReadLine());
            float MonthlyTaxFree = new MonthlyTaxFree;
            float MonthlyInsuranceTax = new MonthlyInsuranceTax;
            float MonthlyNetto = new MonthlyNetto;

            TaxFree(ref BruttoSalary);
            InsuranceTax(ref BruttoSalary);
            NettoSalary(ref MonthlyTaxFree, ref MonthlyInsuranceTax, ref BruttoSalary);
            Console.WriteLine($"Netto salary is: {MonthlyNetto}")
        }
        static void TaxFree(ref float BruttoSalary)
        {
            float YearlySalary = BruttoSalary * 12;
            float MonthlyTaxFree = 0;
            if YearlySalary <= 14400{
                MonthlyTaxFree = 6000 / 12;
            }
            else if (YearlySalary > 14 400 && YearlySalary <= 25200){
                MonthlyTaxFree = 6000 - 6000 / 10800 * (BruttoSalary - 14400);
            }
            else
            {
                MonthlyTaxFree = 0;
            }

        }
        static void InsuranceTax(ref float BruttoSalary)
        {
            double tax = 0.012;
            float MonthlyInsuranceTax =   BruttoSalary * double tax;
        }
        static void NettoSalary(ref float MonthlyTaxFree, ref float MonthlyInsuranceTax, ref float BruttoSalary)
        {
            float MonthlyNetto = BruttoSalary - (MonthlyInsuranceTax + MonthlyTaxFree);
        }
    }
}

