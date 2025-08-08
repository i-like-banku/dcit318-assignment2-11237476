using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound.");
    }
}

class Dog : Animal
{
  public override void MakeSound()
    {
        Console.WriteLine("Bark")
    }
}

//

