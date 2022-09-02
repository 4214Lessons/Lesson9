using static System.Console;

namespace Lesson9_3;




abstract class Human
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateOnly BirthDate { get; set; }

    public override string ToString()
        => $@"Name: {Name}
Surname: {Surname}
BirthDate: {BirthDate}";
}

abstract class Employee : Human
{
    public string? Position { get; set; }
    public double Salary { get; set; }

    public override string ToString()
        => $@"{base.ToString()}
Position: {Position}
Salary: {Salary}";
}



interface IWorker
{
    bool IsWorking { get; set; }
    void Work();
}

interface IManager
{
    void Organize();
    void Control();
    void MakeBudget();
}




class Seller : Employee, IWorker
{
    public bool IsWorking { get; set; }
    public void Work() => WriteLine("Seller Work");
}


class Cashier : Employee, IWorker
{
    public bool IsWorking { get; set; }
    public void Work() => WriteLine("Cashier Work");
}



class Director : Employee, IWorker, IManager
{
    public bool IsWorking { get; set; }

    public void Control() => WriteLine("Director Control");

    public void Work() => WriteLine("Director Work");

    public void MakeBudget() => WriteLine("Director MakeBudget");

    public void Organize() => WriteLine("Director Organize");
}




class Program
{
    static void Main()
    {
        List<IWorker> workers = new List<IWorker>();

        workers.Add(new Seller());
        workers.Add(new Seller());
        workers.Add(new Seller());
        workers.Add(new Cashier());
        workers.Add(new Cashier());
        workers.Add(new Director());

        foreach (var worker in workers)
            worker.Work();

    }
}