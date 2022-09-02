using static System.Console;

namespace Lesson9_6;

// Implicit and Excplicit implement


interface IA
{
    void Get();
}

interface IB
{
    void Get();
}


class Some : IA, IB
{
    void IA.Get() => WriteLine("IA.Get");

    void IB.Get() => WriteLine("IB.Get");

    public void Get() => WriteLine("IAB.Get");
}



class Program
{
    static void Main()
    {
        Some some = new Some();
        some.Get();
        ((IA)some).Get();
        ((IB)some).Get();
    }
}