using static System.Console;

namespace Lesson9_1;

// Inheritance (is a)
// Association (has a, part of)
// Interface   (can do, multiple base)



abstract class Car { }


interface ITurbo
{
    void Turbo();
}

interface ISport
{
    void Sport();
}

interface IClassic
{
    void Classic();
}




class Mercedes : Car, ITurbo, ISport, IClassic
{
    public void Classic() => WriteLine("Mercedes Classic");

    public void Sport() => WriteLine("Mercedes Sport");

    public void Turbo() => WriteLine("Mercedes Turbo");
}


class Lada : Car, IClassic
{
    public void Classic() => WriteLine("Lada Classic");
}


class Program
{
    static void Main()
    {
        // Mercedes car = new Mercedes();
        ISport car = new Mercedes();
        car.Sport();



        // (car as ITurbo)?.Turbo();





        List<IClassic> cars = new();

        cars.Add(new Lada());
        cars.Add(new Mercedes());

        foreach (var c in cars)
            c.Classic();



    }
}