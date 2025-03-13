// See https://aka.ms/new-console-template for more information
TestMethod();

Console.WriteLine("Hello, World!");



 void TestMethod()
{
    Console.WriteLine("Test output");
}

TestMethod();

int TestMethod2(int st)
{
    int x;
    x = st * 2; 
    return x; 
}

Console.WriteLine(TestMethod2(5));