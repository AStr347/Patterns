using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasad1
{
    class Screen
    {
        public void Up() { Console.WriteLine("Scree up"); }
        public void Down() { Console.WriteLine("Scree down"); }
    }

    class PopcornMachine
    {
        bool on;
        public void On() { on = true; Console.WriteLine("PopcornMachine on"); }
        public void Pop()
        {
            if (on)
            {
                Console.WriteLine("unload popcorn");
            }
            else
            { Console.WriteLine("popcorn not ready because machine off"); }
        }
        public void Off()
        {
            if (on)
            {
                Pop();
            }
            Console.WriteLine("PopcornMachine off");
        }
    }

    interface ISource
    {
        void On();
        void Off();
        void Play();
        string getName();
    }

    class DVD : ISource
    {
        string disc, name;
        public DVD(string d) { disc = d; name = "DVD"; }
        public void On() { Console.WriteLine("On dvd"); }
        public void Play() { Console.WriteLine("Play" + "  " + disc); }
        public string getName() { return name; }
        public void Off() { Console.WriteLine("Off dvd"); }
    }

    class Projector
    {
        ISource source;
        string mode = "Normal";
        public void setSource(ISource s) { source = s; }
        public void WideScreenMode() { mode = "Wide"; }
        public void On() { Console.WriteLine("On Projector with mode {0} and source {1}", mode, source.getName()); }
        public void Off() { Console.WriteLine("Off Projector"); }
    }

    class Amp
    {
        ISource source;
        int vol = 0;
        string SoundType = "Classic";
        public void setSource(ISource s) { source = s; }
        public void setVolume(int v) { vol = v; }
        public void setSurroundSound() { SoundType = "Surround"; }
        public void On() { Console.WriteLine("On AMP with volume {0} and source {1}", vol, source.getName()); }
        public void Off() { Console.WriteLine("Off AMP"); }
    }
}
