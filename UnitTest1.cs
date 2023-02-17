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

    [Test]
    public void WhereInnit()
    {
        var list = new List<int>();
        var expected = new List<int>();
        var actual = list.CoolWhere((el) => true);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestAggregate()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var func = new Func<int, int, int>((x, y) => x + y);
        var oldLinqResult = list.Aggregate(func);
        var ourResult = list.CoolAggregate(func);
        Assert.AreEqual(oldLinqResult, ourResult);
    }
}