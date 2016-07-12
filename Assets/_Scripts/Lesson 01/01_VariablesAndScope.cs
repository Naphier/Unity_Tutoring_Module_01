#region Pragma Example - ONLY USE THIS IF YOU'RE REALLY REALLY SURE - Basically never ;)
#pragma warning disable 0168, 0414
#endregion

public class VariablesAndScope
{
    #region Common variable types

    object iCanBeAnything;
    bool myBoolean = true;
    int myInt = 10;
    char myCharacter = 'a';
    float myFloat = 10.1f;
    string myString = "Hello friend!";

    void IDontReturnAnything()
    {
        var mustBeAssigned = 10;
    }

    object IReturnAnyObject()
    {
        return 200;
    }

    bool IReturnABool()
    {
        return false;
    }

    int IReturnAnInt()
    {
        return myInt;
    }

    //etc...
    #endregion

    #region Variable Scopes

    // Class level scope
    string myClassLevelString = "Hello friend";

    void MyMethod()
    {
        myClassLevelString = "I'm available!";

        // Method-level scope 
        string myMethodLevelString = "I'm only available in this method";
        
        if (true)
        {
            myMethodLevelString.ToString(); // Still available!

            string myBlockLevelString = "I'm only available in this block's scope";
            myBlockLevelString.ToString();
        }

        //myBlockLevelString = ""; // ERROR! not available outside of the block it was declared in!

        string[] myStringArray = new string[10];
        
        // Other types of blocks
        for (int i = 0; i < myStringArray.Length; i++)
        {

        }
        
        foreach (var item in myStringArray)
        {

        }

        bool myBool = true;
        while (myBool)
        {
            myBool = false;
        }

        int number = 0;
        number += 1;
        switch (number)
        {
            default:
                break;
        }
    }

    void SomeOtherMethod()
    {
        //myMethodLevelString = ""; // ERROR! not available outside of MyMethod()
    }

    void AccessAnotherClass()
    {
        // Class objects are instantiated
        ClassWithPublicVariables aClassWithPublicVariables = new ClassWithPublicVariables();
        // We have access to the PUBLIC variable in that class.
        aClassWithPublicVariables.myPublicInt = 10;

        // We do not have access to its PRIVATE variables
        //aClassWithPublicVariables.myPrivateInt;

        ClassWithPublicVariables bClass = new ClassWithPublicVariables();
        // this class is a different instance
        bClass.myPublicInt = 100;
        //aClassWithPublicVariables.myPublicInt != bClass.myPublicInt
    }
    #endregion
}


public class ClassWithPublicVariables
{
    public int myPublicInt;
    private int myPrivateInt;
}

#pragma warning restore
