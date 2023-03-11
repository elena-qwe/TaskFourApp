namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    [Test]
    public static void MethodMoreBetweenTwoNumbers()
    {
        Assert.IsTrue(TaskFourApp.Program.MethodMoreBetweenTwoNumbers(2, 1));
    }
    
    [Test]
    public static void MethodMinBetweenTwoNumbers()
    {
        Assert.IsFalse(TaskFourApp.Program.MethodMoreBetweenTwoNumbers(1, 2));
    }
    
    [Test]
    public static void MethodMeterToCentimeter()
    {
        Assert.That(TaskFourApp.Program.MethodMeterToCentimeter(5), Is.EqualTo(500));
    }
    
    [Test]
    public static void MethodMeterToCentimeterFail()
    {
        Assert.That(TaskFourApp.Program.MethodMeterToCentimeter(1), Is.EqualTo(9));
    }
    

    [Test]
    public static void MethodCheckDataFail()
    {
        Assert.IsFalse(TaskFourApp.Program.MethodCheckData(30, 2));
    }
    
    [Test]
    public static void MethodCheckData()
    {
        Assert.IsTrue(TaskFourApp.Program.MethodCheckData(26, 2));
    }
    
    [Test]
    public static void MethodAuthUser()
    {
        Assert.IsTrue(TaskFourApp.Program.MethodAuthUser("login", "password"));
    }
    
    [Test]
    public static void MethodAuthUserFail()
    {
        Assert.IsFalse(TaskFourApp.Program.MethodAuthUser("admin", "password"));
    }

    [Test]
    public static void MethodRegisterUser()
    {
        Assert.IsTrue(TaskFourApp.Program.MethodRegisterUser("admin", "admin", "admin@admin.com", "5/01/2008"));
    }
    
    [Test]
    public static void MethodRegisterUserFail()
    {
        Assert.IsFalse(TaskFourApp.Program.MethodRegisterUser("admin", "admin", "admin", "5/01/2008"));
    }
}