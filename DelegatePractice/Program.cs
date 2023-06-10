// See https://aka.ms/new-console-template for more information

using DelegatePractice;

TestDelegate.UseDelegateFunction();

MultiDelegate m = Method1;
m += Method2;
m();

Console.ReadKey();

static void Method1()
{
    Console.WriteLine("Invoked method 1");
}

static void Method2()
{
    Console.WriteLine("Invoked method 2");
}
public delegate void MultiDelegate();