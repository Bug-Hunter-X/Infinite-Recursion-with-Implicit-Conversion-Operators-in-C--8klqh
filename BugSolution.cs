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

    public static explicit operator MyClass(int value)
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

        // The following line now works correctly because we use an explicit conversion.
        MyClass myClass2 = (MyClass)(value + 1); //Explicit conversion to avoid infinite loop
        Console.WriteLine(myClass2.MyProperty); // Output: 6
    }
} 