using NUnit.Framework;

namespace ATM.Tests;


public class TestCrendials
{
    private Menus? menu;
    // Passing Check / Test project, which references logic project
    [Test]
    public void TestPassingCredentials()
    {
        var class1 = new Class1();
        var menus = new Menus();
        Assert.IsTrue(class1.LoginCheck("Marco Andres Barreno", "233702", "Marco Andres Barreno", "233702"));
    }
    [Test]
    public void TestFailedCredentials()
    {
        var class1 = new Class1();
        var menus = new Menus();
        Assert.IsTrue(class1.LoginCheck("Marco Barreno", "2337", "Marco Andres Barreno", "233702"));
    }
   
}