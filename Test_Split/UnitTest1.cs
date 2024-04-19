using ClassLibrary;
namespace Test_Split;

[TestClass]
public class UnitTest1
{
    //Tests for SplitAmount method
    private Class1 classInstance; 

    [TestInitialize]
    public void Setup()
    {
        classInstance = new Class1(); 
    }

    [TestMethod]
    public void SplitAmount_ValidInput_ReturnsCorrectAmount()
    {
        
        decimal totalAmount = 100.0m;
        int totalPeople = 5;
        decimal expectedSplitAmount = 20.0m;

        decimal actualSplitAmount = classInstance.SplitAmount(totalAmount, totalPeople);

        Assert.AreEqual(expectedSplitAmount, actualSplitAmount, "Split amount per person is incorrect.");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SplitAmount_ZeroTotalPeople_ThrowsArgumentException()
    {

        decimal totalAmount = 100.0m;
        int totalPeople = 0; // Zero total people

        decimal actualSplitAmount = classInstance.SplitAmount(totalAmount, totalPeople);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SplitAmount_NegativeTotalPeople_ThrowsArgumentException()
    {

        decimal totalAmount = 100.0m;
        int totalPeople = -5; // Negative total people    
        decimal actualSplitAmount = classInstance.SplitAmount(totalAmount, totalPeople);
        
    }

    // Tests for CalculateTip
     [TestMethod]
   
    public void CalculateTip_ValidInput_ReturnsCorrectTipAmounts()
    {
        // Arrange
        Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>
        {
            { "Pratham", 65.70m },{ "Arein", 69.96m },{ "Dharmil", 23.75m }
        };
        float tipPercentage = 20.0f;

        // Act
        Dictionary<string, decimal> tipAmounts = classInstance.CalculateTip(mealCosts, tipPercentage);

        // Assert
        // Add assertions to check the correctness of tip amounts
        // For example:
        Assert.AreEqual(5.63m, tipAmounts["Pratham"], "Incorrect tip amount for Pratham.");
        Assert.AreEqual(8.73m, tipAmounts["Arein"], "Incorrect tip amount for Arein.");
        Assert.AreEqual(6.85m, tipAmounts["Dharmil"], "Incorrect tip amount for Dharmil.");
    }
 [TestMethod]
   
    public void CalculateTip_NullMealCosts_ThrowsArgumentNullException()
    {

        Dictionary<string, decimal> mealCosts = null;
        float tipPercentage = 20.0f;

        Dictionary<string, decimal> tipAmounts = classInstance.CalculateTip(mealCosts, tipPercentage);
    }
 [TestMethod]
   
    public void CalculateTip_InvalidTipPercentage_ThrowsArgumentException()
    {
        Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>
        {
            { "Pratham", 65.70m },
            { "Arein", 31.96m }
        };
        float invalidTipPercentage = -56.0f;

        Dictionary<string, decimal> tipAmounts = classInstance.CalculateTip(mealCosts, invalidTipPercentage);

    }

    //Tests for SCalculateTipPerPersont method

    [TestMethod]
    public void CalculateTipPerPerson_ValidInput_ReturnsCorrectTipPerPerson()
    {
        decimal price = 100.0m;
        int numberOfPatrons = 5;
        float tipPercentage = 15.0f;
        decimal expectedTipPerPerson = 3.0m;

        decimal actualTipPerPerson = classInstance.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);
        Assert.AreEqual(expectedTipPerPerson, actualTipPerPerson, "Tip per person is incorrect.");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateTipPerPerson_ZeroPrice_ThrowsArgumentException()
    {
        decimal price = 0m;
        int numberOfPatrons = 5;
        float tipPercentage = 15.0f;

        decimal actualTipPerPerson = classInstance.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateTipPerPerson_NegativeNumberOfPatrons_ThrowsArgumentException()
    {
        decimal price = 100.0m;
        int numberOfPatrons = -5; 
        float tipPercentage = 15.0f;

        decimal actualTipPerPerson = classInstance.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

    }


}