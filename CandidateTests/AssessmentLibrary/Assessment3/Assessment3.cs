using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssessmentLibrary.Assessment3;
public class Assessment3
{
    public static decimal CalculateGrossAmount(decimal amount, decimal taxPercentage)
    {
        return amount / (1 -taxPercentage/100);
        // Given a specified Nett amount, calculate the gross amount before tax deduction.
        // throw new NotImplementedException();
    }

    public static decimal CalculateGrossAmount(decimal amount, decimal level1Threshold, decimal level1TaxPercentage,
        decimal level2TaxPercentage)
    {
        // Given a specified Nett amount, calculate the gross amount before tax deduction
        // Where the first level1Treshold gross amount is taxed at level1TaxPercentage 
        // and the balance is taxed at level2TaxPercentage.
        //
        // Eg: Gross of £325 is taxed as follows:
        //     First £125 taxed @ 20%
        //     Balance taxed @ 50%
        //
        // 20% of 125 = 25. 
        // 325 - 125 = 200.
        // 50% of 200 = 100.
        // Total Tax: 25 + 100 = 125
        // Nett (Gross - Tax): 325 - 125 = 200
        // throw new NotImplementedException();

        if (amount >= level1Threshold)
        {
            var f = level1Threshold * level1TaxPercentage / 100;
            var s = (amount - level1Threshold ) * level2TaxPercentage / 100;

            return amount - f - s;
        }
        else
        {
            return amount - (amount * level1TaxPercentage / 100);
        }
    }
}