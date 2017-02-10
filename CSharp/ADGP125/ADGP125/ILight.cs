
using System.Diagnostics;

namespace ADGP125
{
    public interface ILight
    {
        bool Update();
        bool Exit(ILight currentState);
        void Enter();
    }

    class GreenLight : ILight
    {
        public GreenLight() { }
        public Stopwatch sw = new Stopwatch();

        public void Enter()
        {
            sw.Start();
            sw.Restart();
            Update();
        }
        public bool Update()
        {
            var elapsed = sw.Elapsed.Seconds;
            Debug.WriteLine("              GreenLight: " + elapsed);
            if (elapsed >= 33)
            {
                return Exit(this);
            }
            return false;
        }

        public bool Exit(ILight currentState)
        {
            sw.Stop();
            sw.Reset();
            return true;
        }
    }


    class YellowLight : ILight
    {
        public YellowLight() { }
        public Stopwatch sw = new Stopwatch();

        public void Enter()
        {
            sw.Start();
            Update();
        }
        public bool Update()
        {
            var elapsed = sw.Elapsed.Seconds;
            Debug.WriteLine("                               YellowLight: " + elapsed);
            if (elapsed >= 7)
            {
                return Exit(this);
            }
            return false;
        }
        public bool Exit(ILight currentState)
        {
            sw.Stop();
            sw.Reset();
            return true;
        }
    }
    class RedLight : ILight
    {
        public RedLight() { }
        public Stopwatch sw = new Stopwatch();

        public void Enter()
        {
            sw.Start();
            Update();
        }
        public bool Update()
        {
            var elapsed = sw.Elapsed.Seconds;
            Debug.WriteLine("RedLight: " + elapsed);
            if (elapsed >= 40)
            {
                return Exit(this);
            }
            return false;
        }
        public bool Exit(ILight currentState)
        {
            sw.Stop();
            sw.Reset();
            return true;
        }
    }
}
