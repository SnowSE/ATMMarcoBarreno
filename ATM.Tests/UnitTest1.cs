using NUnit.Framework;

namespace ATM.Tests;


public class Tests
{
    private Menus? menu;
    // Passing Check / Test project, which references logic project
    [Test]
    public void TestPassingCredentials()
    {
        var class1 = new Class1();
        var menus= new Menus();
        Assert.IsTrue(class1.LoginCheck("Marco Andres Barreno", "233702"), menus.username = ("Marco Andres Barreno"), menus.PINCode = ("233702"));
    }
}