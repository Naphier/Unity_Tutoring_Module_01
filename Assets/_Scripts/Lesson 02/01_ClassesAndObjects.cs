#pragma warning disable 0219
public class ClassesAndObjects
{
    public void PlayGround()
    {
        object obj = new ClassesAndObjects();
        object obj2 = 0.1f;
        object obj3 = "yowsers!";

        // object is a special class can be mostly anything.
        // Note the available methods.
        if (obj.Equals(obj2)) { }

        if (obj.GetHashCode() == 1) { }

        if (obj.GetType() == typeof(ClassesAndObjects)) { }

        if (obj.ToString() == "") { }


        int myInt = 0;
        // All other objects (basically everything) have those methods available.
        if (myInt.Equals(1)) { }

        if (myInt.GetHashCode() == 1) { }

        if (myInt.GetType() == typeof(int)) { }

        if (myInt.ToString() == "") { }


        // every thing "inherits" from the object class.
        // but what if we want to do our own inheritance?
    }

    // Let's define some more interesting things.
    public int score;

    public void MoveLeft() { }

    protected int myInt2;
}


// Now let's make a class that inherits from "ClassesAndObjects"
public class CAO2 : ClassesAndObjects
{
    public void Run()
    {
        score++;
        MoveLeft();
        // All methods and variables are inherited to this new class.
        // We can only access the PUBLIC ones (or PROTECTED ones).
    }
}

// Why is this useful??

public class EnemyBase
{
    public int hp;
    public int defense;
    public int attack;
} // All enemies have commonalities

public class Orc : EnemyBase
{
    // Constructors!
    public Orc(int level)
    {
        hp = 10 * level;
        defense = 10 + level * 2;
        attack = 5 + level;

        // Notice that we have the object methods available to us even though we didn't explicitly inherit.
        if (ToString() == "") { } // But what does it do? Probably "Object..." not useful info... so...
    }

    // We define an override!
    public override string ToString()
    {
        return "Orc - hp: " + hp + "  defense: " + defense + "   attack: " + attack;
        // now we have something more informative.
    }

    // All of your classes should override ToString for useful debugging info!
}
#pragma warning restore