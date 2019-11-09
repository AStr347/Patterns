using System;

namespace ConsoleComand
{
    abstract class ASwitch
    {
        protected string name;
        protected string state;
        protected string place;
        public void on() { state = "ON"; }

        public void off(){ state = "OFF"; }

        public override String ToString() { return String.Format("{0}\t{1}\t{2}", name, place, state); }
    }

    abstract class ASterio : ASwitch {
        protected int volume;
        protected string source;
        public void setCD() { source = "CD"; }
        public void setDVD() { source = "DVD"; }
        public void setRadio() { source = "Radio"; }
        public void setVolume(int vol) { volume = vol; }
        public override String ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}", name, place, source, volume.ToString(), state);
        }
    }

    class Sterio : ASterio {
        public Sterio(string _place) {
            name = "Sterio";
            place = _place;
        }
    }


    class Light : ASwitch
    {
        public Light(string _place)
        {
            name = "Light";
            place = _place;
        }
    }
}
