class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("animal sound is too loud");
    }
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("wolf");
    }


}
class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound();


        // so from this objct  i can change the data of Animal
        Animal animal2 = new Dog();
        animal2.MakeSound();
    }
}