#pragma warning disable 0219, 0414

public class Methods
{
    // Methods allow us to organize and make reusable code. 
    // It also helps us to create a structure where we can isolate and test code easily.

    // public methods can be called from external classes
    public void Run()
    {

    }

    // private methods can only be called in the class they belong to
    private void PrivateRun()
    {

    }

    // Methods must have a 'return' type. 'void' means it returns nothing.
    public int GetSomeInt()
    {
        return 10;
    }

    // Methods can accept parameters
    public int MultiplyMe(int a, int b)
    {
        return a * b;
    }

    // Methods can have defaults
    public int MultiplyMe2(int a, int b = 2)
    {
        return a * b;
    }

    public void TestMyltiplyMe2()
    {
        int z = MultiplyMe2(1); // will = 2
        int y = MultiplyMe2(1, 10); // will = 10
    }

    // We use methods to make our code neat and easy to use
    public void Initialize()
    {
        // Set a player's start position
        SetStartPosition();
        // Enable movement
        SetMovementEnabled(true);
        // Set score to 0
        SetScore(0);
        // etc...
    }

    void SetStartPosition() { }

    void SetMovementEnabled(bool enabled)
    {
        if (enabled)
        {
            // allow movement
        }
        else
        {
            // don't allow movement
        }
    }

    private int score = 0;
    void SetScore(int value)
    {
        score = value;
    }

}


#pragma warning restore