#pragma warning disable 0219
public class VariableOperations
{
    void MyMethod()
    {
        int a = 10;
        int b = 20;

        int c = a + b; // results in 30
        c++; // Increment by one - after this line c will equal 31
        c--; // Decrement by one - after this line c will equal 30

        c = a * b;
        c = b / a;

        // Order of operations: Multiply/Divide then Add/Subtract
        c = 10 * a + b; // c = 120
        // use parenthesis to force order
        c = 10 * (a + b); // c = 300
        

        // All of these basic mathematical operations can be applied to most types

        // C# is case sensitive!
        string A = "Hello ";
        string B = "Friend";
        string C = A + B; // 'Hello Friend'

        string oops = "Hello " + 10; // Danger zone! With many types like string this is safe.

        // But what if we do this?
        oops = "Hello" + 10 + 20; // it will be 'Hello30'

        //C = A - B; // Cannot be done!

        // Safety! Convert types properly
        oops = "Hello" + 10.ToString() + 20.ToString(); // Will be Hello1020;

        // Mixing numbers 
        //int mixedInt = 100 + 1.0f; // C# wants you to know you are going to lose info on the float.
        float mixedFloat = 100 + 1.0f; // No problem. Converting the int to a float loses no precision.
        
        // increment, decrement, multiply, or divide by an amount
        mixedFloat += 10; // = 111.0
        mixedFloat *= 2; // = 222.0
        mixedFloat /= 2; // = 111.0
        mixedFloat -= 10; // = 101.0 ... etc...
    }

}
#pragma warning restore
