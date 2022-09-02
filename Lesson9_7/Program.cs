using static System.Console;

namespace Lesson9_7;


interface IDraw
{
    public void Erase() => WriteLine("Default implementation | Erase");
    void Draw();
}

class Rectangle : IDraw
{
    public void Erase() => WriteLine("Rectangle Erase");
    public void Draw() => WriteLine("Rectangle Draw");
}

class Circle : IDraw
{
    public void Draw() => WriteLine("Circle Draw");
}


class Program
{
    static void Main()
    {
        List<IDraw> figures = new();

        figures.Add(new Circle());
        figures.Add(new Rectangle());

        foreach (var fig in figures)
        {
            fig.Draw();
            fig.Erase();
        }
    }
}