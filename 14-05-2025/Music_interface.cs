    interface IMusicPlayer
    {
      public void Play(string song);
       public void Pause();

      public void Stop();



    }
    class SpotifyPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine("Playing " + song + " on Spotify");
            
        }
        public void Pause()
        {
            Console.WriteLine("Spotify playback paused");
        }
        public void Stop()
        {
            Console.WriteLine("Spotify playback stopped");
        }
    }
    internal class AppleMusicPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine("Playing " + song + " on Apple Music");

        }
        public void Pause()
        {
            Console.WriteLine("Apple Music playback paused");
        }
        public void Stop()
        {
            Console.WriteLine("Apple Music playback stopped");
        }
    }
//