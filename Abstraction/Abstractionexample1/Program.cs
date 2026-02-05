using System;
namespace Abstraction
{
    public interface Mediaplayer
    {
        public void Play(string path);
    }
    public class Audioplayer: Mediaplayer
    {
        public void Play(string path)
        {
            Console.WriteLine($"file name is {path}");
        }
    }
    public class Videoplayer : Mediaplayer
    {
        public void Play(String path)
        {
            Console.WriteLine($"video file naem is {path}");
        }
    }
    class Program
    {
        public static void Main()
        {
            Mediaplayer audio = new Audioplayer();
            Mediaplayer video = new Videoplayer();
            Playing(audio, "audio.mp3");
            Playing(video, "video.mp4");
        }
        static void Playing(Mediaplayer media , string path)
        {
            media.Play(path);
        }
    }
}
    