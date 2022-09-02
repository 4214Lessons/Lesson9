namespace Lesson9_4;

// Interface extend


interface IFoo
{
    void Foo();
}

interface IBoo : IFoo // Extend
{
    void Boo();
}


struct Any : IBoo
{
    public void Boo() => new NotImplementedException();
    public void Foo() => new NotImplementedException();
}