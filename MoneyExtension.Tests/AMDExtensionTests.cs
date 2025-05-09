namespace AMDExtension.Tests;

[TestClass]
public class AMDExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        Decimal valor = 279.98M;
        var cents = valor.ToCents();
        Assert.AreEqual(27998, cents);
    }
}