namespace TestDateFormat;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateValidFormat()
    {
        const string input = "25/09/1999";
        const string expected = "1999-09-25";

        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void DateWrongFormat()
    {
        const string input = "1999/09/25";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void DateEmpty()
    {
        const string input = "";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void DateWrongSeparators()
    {
        const string input = "25-09-1999";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void DateWrongLength()
    {
        const string input = "25/09/19999";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void DateOutOfBounds()
    {
        const string input = "25/19/1999";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}