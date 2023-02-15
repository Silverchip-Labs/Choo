namespace Choo;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Assert.Pass();
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var func = new Func<int, int>(x => x * 2);
        var oldLinqResult = list.Select(func);
        var ourResult = list.CoolSelect(func);
        Assert.AreEqual(oldLinqResult, ourResult);
    }
}