namespace ClassLibrary;

public class Class1
{

    // Created the First method
    public decimal SplitAmount(decimal totalAmount, int totalPeople)
    {
        if (totalPeople <= 0)
        {
            throw new ArgumentException("Please add a member.");
        }

        return totalAmount / totalPeople;
    }

    // Created the Second method
    public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        if (mealCosts == null)
        {
            throw new ArgumentNullException(nameof(mealCosts));
        }

        if (tipPercentage < 0 || tipPercentage > 100)
        {
            throw new ArgumentException("Tip percentage must be between 0 and 100.");
        }

        decimal totalMealCost = mealCosts.Values.Sum();
        decimal totalTipAmount = totalMealCost * (decimal)(tipPercentage / 100);

        Dictionary<string, decimal> tipAmounts = mealCosts
            .ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value / totalMealCost * totalTipAmount
            );

        return tipAmounts;
    }

    // Created the third  method
    public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
    {
        if (price <= 0)
        {
            throw new ArgumentException("Price must be greater than zero.");
        }

        if (numberOfPatrons <= 0)
        {
            throw new ArgumentException("Number of patrons must be greater than zero.");
        }

        if (tipPercentage < 0 || tipPercentage > 100)
        {
            throw new ArgumentException("Tip percentage must be between 0 and 100.");
        }

        decimal totalTipAmount = price * (decimal)(tipPercentage / 100);
        decimal tipPerPerson = totalTipAmount / numberOfPatrons;

        return tipPerPerson;
    }

}