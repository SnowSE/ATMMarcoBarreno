using NUnit.Framework;

namespace ATM.Tests;

public class MenuSelection
{
    [Test]
    public void TestSelectMenu()
    {
        var class1 = new Class1();
        var menus = new Menus();
        Assert.AreEqual(800, Menus.initialValue);

    }
}
