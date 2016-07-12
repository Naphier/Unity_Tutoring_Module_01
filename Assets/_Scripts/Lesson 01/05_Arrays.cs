#pragma warning disable 0219, 0414

public class Arrays
{
    // Arrays - just about any object can have an array type
    bool[] boolArray = new bool[10];
    int[] intArray = new int[1];

    void DoSomeCoolStuff()
    {
        int[] myValues = { 1, 2, 3, 4, 5 }; // we can explicitly fill arrays when declared

        // You can access the value of an array element with the indexer.
        if (myValues[0] == 1) { } // arrays start at index = 0

        if (myValues[myValues.Length - 1] == 5) { } // we get the total number of elements in the array with Length
        // but the last element is Length - 1 since the array index starts at 0.

        // Access an array out of range will throw a nasty error
        //myValues[100]
        // So always check the index before accessing
        int index = 100;
        if (index > 0 && index < myValues.Length - 1)
        {
            // we're safe to do something with the array because we're in range
            myValues[index] = 10;
        }


        // Arrays allow us to do batch operations
        for (int i = 0; i < myValues.Length; i++) // for loops need to know how many ITERATIONS to make (i = index)
        {
            myValues[i] *= 2;
        }

        // we can use foreach loops if we don't need to know the index
        // and we're not changing the values in the array
        int sum = 0;
        foreach (var item in myValues)
        {
            sum += item;
        }

        // just about any object can have an array
        object[] myObjectArray = new object[10];
        string[] myStrings = new string[100];

        // arrays cannot be resized :(
        // so, myStrings will always have a size of 100
        // if we want to add more then it takes a lot of extra memory
        string[] temp = new string[200];
        for (int i = 0; i < myStrings.Length; i++)
        {
            temp[i] = myStrings[i];
        }

        myStrings = temp; // temp array will be remove from memory when the method is done.


        // SO we have some awesome special arrays called LISTS

        System.Collections.Generic.List<string> myList = new System.Collections.Generic.List<string>();
        
        if (myList.Count == 0) { } // list sizes are accessed by Count instead of Length

        for (int i = 0; i < 100; i++)
        {
            myList.Add("some string");
        }

        // Count will now be 100!

        // Count will now be 99 and the 0th element is removed and all other elements shift down by an index
        myList.RemoveAt(0);

        // for example
        myList[0] = "Hello";
        myList[1] = "Good bye";
        myList.RemoveAt(0);
        // myList[0] is now "Good bye"!!

        // We can also remove by the element's value
        myList.Remove("Good bye");

        // We can check easily if a value exists in the List
        if (myList.Contains("Good bye"))
        {
            // should be impossible since we just removed the only element containing "Good by"
        }


        // other loops
        int loop = 0;
        while (loop < 10)
        {
            loop++;
        } // final loop value will be 10.

        loop = 0;
        do
        {
            loop++;
        } while (loop < 10); // final loop value will be 9.
    }

}

#pragma warning disable