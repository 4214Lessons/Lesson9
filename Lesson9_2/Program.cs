using static System.Console;

namespace Lesson9_2;

interface IKiller
{
    void Kill();
}

interface IFighter
{
    void Attack();
    void Fire();
    void Shot();
}


interface IManage
{
    void Control();
    void CompleteMission();
    void GatherPoeple();
}


class Fighter : IKiller, IFighter
{
    public virtual void Kill() => WriteLine("Fighter Kill");

    public void Attack() => WriteLine("Fighter Attack");
    public void Fire() => WriteLine("Fighter Fire");
    public void Shot() => WriteLine("Fighter Shot");
}


class Commander : Fighter, IManage
{
    public override void Kill() => WriteLine("Commander Kill");

    public new void Attack() => WriteLine("Commander Attack");

    public void CompleteMission() => WriteLine("Commander CompleteMission");
    public void Control() => WriteLine("Commander Control");
    public void GatherPoeple() => WriteLine("Commander GatherPoeple");
}


class Program
{
    static void Main()
    {
        IKiller fighter = new Commander();
        fighter.Kill();
    }
}