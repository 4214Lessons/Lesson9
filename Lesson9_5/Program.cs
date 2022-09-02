using static System.Console;

namespace Lesson9_5;


// SOLID
// Interface Segregation Principle


interface IAudioPlayer
{
    void PlayAudio();
}

interface IVideoPlayer
{
    void PlayVideo();
}


class DivMediaPlayer : IAudioPlayer, IVideoPlayer
{
    public void PlayAudio() => WriteLine("DivMediaPlayer PlayAudio");
    public void PlayVideo() => WriteLine("DivMediaPlayer PlayVideo");
}


class Winamp : IAudioPlayer
{
    public void PlayAudio() => WriteLine("Winamp PlayAudio");
}


class VicMediaPlayer : IVideoPlayer
{
    public void PlayVideo() => WriteLine("VicMediaPlayer PlayVideo");
}



class Program
{
    static void Main()
    {
        List<IAudioPlayer> players = new();

        players.Add(new DivMediaPlayer());
        // players.Add(new VicMediaPlayer());
        players.Add(new Winamp());

        foreach (var p in players)
        {
            // p.PlayVideo();
            p.PlayAudio();
        }
    }
}