namespace ATM.Tests;
using NUnit.Framework;


public class OptionMenuTests
{
    [Test]
    public void PaytransPass()
    {
        var class1 = new Class1();
        var payTrans = new PayTrans();
        Assert.AreEqual(790, payTrans.Payment(800, 10));
    }
    [Test]
    public void PaytransFailed()
    {
        var class1 = new Class1();
        var payTrans = new PayTrans();
        Assert.AreEqual(780, payTrans.Payment(800, 10));
    }
    [Test]
    public void CheckPass()
    {
        var menus = new Menus();
        Assert.IsTrue(menus.Check("y"));

    }
}
