using System;

namespace sssq_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Какузу", new DateTime(2017, 05, 26));
            Console.WriteLine($" Возраст Какузу: {dog.Age()} года");
            ((IWalking)dog).Walk();

            Fish fish = new Fish("Кисаме", new DateTime(2016, 08, 19));
            Console.WriteLine($" Возраст Кисаме: {fish.Age()} года");
            ((ISwimming)fish).Walk();

            Bird bird = new Bird("Дейдара", new DateTime(2014, 03, 29));
            Console.WriteLine($" Возраст Дейдары: {bird.Age()} лет");
            ((IFlying)bird).Walk();

            Butterfly butterfly = new Butterfly("Конан", new DateTime(2020, 11, 14));
            Console.WriteLine($" Возраст Конан: {butterfly.Age()} лет");
            ((IFlying)butterfly).Walk();
        }
    }
}
