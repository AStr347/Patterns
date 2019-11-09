using System;

namespace ConsoleComand
{
    interface ICommand
    {
        void execute();
        void undo();
    }

    class NoCommand : ICommand {
        public void execute() { Console.WriteLine("NoCommand"); }
        public void undo() {  }
    }

    class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light _light) { light = _light; }

        public void execute() { light.off(); Console.WriteLine(light); }

        public void undo() { light.on(); }
    }

    class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light _light) { light = _light; }

        public void execute() { light.on(); Console.WriteLine(light); }

        public void undo() { light.off(); }
    }

    class StereoOnWithCDCommand : ICommand {
        Sterio sterio;
        public StereoOnWithCDCommand(Sterio ster) { sterio = ster; }
        public void execute() {
            sterio.on();
            sterio.setCD();
            sterio.setVolume(11);
            Console.WriteLine(sterio);
        }
        public void undo() {
            sterio.off();
        }
    }

    class StereoOnWithRadioCommand : ICommand
    {
        Sterio sterio;
        public StereoOnWithRadioCommand(Sterio ster) { sterio = ster; }
        public void execute()
        {
            sterio.on();
            sterio.setRadio();
            sterio.setVolume(11);
            Console.WriteLine(sterio);
        }
        public void undo()
        {
            sterio.off();
        }
    }

    class StereoOnWithDVDCommand : ICommand
    {
        Sterio sterio;
        public StereoOnWithDVDCommand(Sterio ster) { sterio = ster; }
        public void execute()
        {
            sterio.on();
            sterio.setDVD();
            sterio.setVolume(11);
            Console.WriteLine(sterio);
        }
        public void undo()
        {
            sterio.off();
        }
    }


    class StereoOff : ICommand
    {
        Sterio sterio;
        public StereoOff(Sterio ster) { sterio = ster; }
        public void execute()
        {
            sterio.off();
            Console.WriteLine(sterio);
        }
        public void undo()
        {
            sterio.on();
        }
    }


}
