using Jivotnie;

namespace Jivotnie
{
    class Program
    {
        public static void Main(string[] args)
        {
            Veterinar veterinar = new Veterinar();
            Animal[] animal = new Animal[3];
            animal[0] = new Dog(spasat: "не спасает", food: "педегри", location: "деревня");
            animal[1] = new Cat(linyat: "линять законнчилось", food: "обои", location: "квартира");
            animal[2] = new Horse(run: "быстро бежит", food: "овёс", location: "загородный участок");
            Console.WriteLine(animal[0]);
            Console.WriteLine(animal[1]);
            Console.WriteLine(animal[2]);
            //     Console.WriteLine(veterinar.treatAnimal);
        }
    }
}
