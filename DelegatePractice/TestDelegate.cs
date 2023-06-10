namespace DelegatePractice;

public static class TestDelegate
{
    public delegate int SimpleDelegate(string s);

    public delegate void EventHandler(string value);

    private static int StringLength(string s)
    {
        return s.Length;
    }

    public static event EventHandler ErrorOccured;

    public static void UseDelegateFunction()
    {
        SimpleDelegate d = StringLength;
        int length = d.Invoke("Hello World");
        Console.WriteLine("Result is: " + length);

        ErrorOccured += SomethingHappened;
        ErrorOccured("Exception in main thread");
    }

    public static void SomethingHappened(string value)
    {
        Console.WriteLine(value);
    }
}