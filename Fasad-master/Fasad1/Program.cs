using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasad1
{

    class HomeCinema
    {
        Screen screen;
        PopcornMachine popcorn;
        Amp amp;
        Projector projector;
        ISource source;

        public HomeCinema(ISource s) {
            screen = new Screen();
            popcorn = new PopcornMachine();
            amp = new Amp();
            projector = new Projector();
            source = s;
            amp.setSource(s);
            projector.setSource(s);
        }

        public void WatchMovie() {
            screen.Down();
            popcorn.On();
            amp.setVolume(10);
            amp.setSurroundSound();
            amp.On();
            projector.WideScreenMode();
            projector.On();
            popcorn.Pop();
            popcorn.Off();
            source.On();
            source.Play();
        }

        public void EndMovie() {
            screen.Up();
            popcorn.Off();
            amp.Off();
            projector.Off();
            source.Off();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DVD dvd = new DVD("Lion King");
            HomeCinema hc = new HomeCinema(dvd); ;
            hc.WatchMovie();
            Console.WriteLine("\n\n");
            hc.EndMovie();
            Console.ReadLine();
        }
    }
}
