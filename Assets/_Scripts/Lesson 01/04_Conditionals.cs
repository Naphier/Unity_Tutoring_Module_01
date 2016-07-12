
public class Conditionals
{
    // Conditionals allow us to make decisions!

    int DivideMe(int a, int b)
    {
        if (a == 0) // IS EQUAL TO
        {
            // Don't divide by zero!!
            return 0;
        }
        else
        {
            return b / a;
        }
    }

    void SomeOtherConditionals()
    {
        int a = 1;
        int b = 2;

        if (a != b)
        {
            // Tell the user they aren't equal
        }

        if (b > a)
        {
            // b is larger than a
        }

        if (b < a)
        {
            // b is smaller than a
        }

        if (b >= a)
        {
            // b is greater than or equal to a
        }

        if (b <= a)
        {
            // b is less than or equal to a
        }


        // Logical operations

        // AND

        if (a == 1 && b == 2) // both conditions must be true
        {
            // pass!
        }


        // OR

        if (a == 1 || b == 100) // either condition must be true
        {
            // a == 1 so we will pass
        }


        // ELSE

        if (a == 10)
        {
            // yay a is 10!
        }
        else
        {
            // a is not 10 :(
        }


        // Complex conditions - USE PARENTHESIS!
        if ((a > 0 && a < 2) || a == 100)
        {
            // pass if a is 1 or if a is 100
        }


        // Use whitespace when things get crazy!

        if ((a > 0 && a < 100) ||
            (b > 0 && b < 100) ||
            ((b + a) == 200)
            )
        {

        }

        // nesting ifs 
        if (a > 0)
        {
            if (a < 100)
            {
                // a is greater than 0 and a is less than 100
            }
        }


        // So many conditions... can we use SWITCH?
        int switchValue = 10;

        switch (switchValue)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
            case 4:
            case 5: // stack multiples for an OR effect
                break;
            default: // acts like ELSE
                break;
        }



    }


}
