using StrykerConsole;

namespace Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        var foobar = new Foobar(42);
        var addedValues = foobar.AddedValues();
        Assert.AreEqual(126, addedValues);
    }
}
