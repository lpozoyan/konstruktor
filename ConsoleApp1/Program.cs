Test test = new Test("hi");
public class TestBase
{
    
    public TestBase (string m)
    {
        Console.WriteLine(" hi im constr 1");
        Console.WriteLine(m);
    }
}
public class Test : TestBase
{
    

    public Test(string m) : base("im constr 2")
    {
        Console.WriteLine(" hi im constr 2");
        Console.WriteLine(m);
    }

   
}