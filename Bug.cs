public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass myClass = 5; // Implicit conversion from int to MyClass
        int value = myClass; // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 5

        // The following line throws an exception because it causes an infinite loop.
        MyClass myClass2 = myClass + 1; // Implicit conversion from int to MyClass, then addition, then implicit conversion back to MyClass. Infinite recursion
        Console.WriteLine(myClass2); 
    }
}