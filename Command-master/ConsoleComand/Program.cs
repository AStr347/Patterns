using System;

namespace ConsoleComand
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * init RemoteControl Light (in Kitchen and Living room) and Sterio in Living room
             */
            RemoteControl control = new RemoteControl(7);

            Light lightKitchen = new Light("Kitchen");
            Light lightLiving = new Light("Living room");
            Sterio sterio = new Sterio("Living room");
            /*
             * init Light on/off for Lights and Sterio
             */
            LightOnCommand lightOnKitchen = new LightOnCommand(lightKitchen);
            LightOnCommand lightOnLiving = new LightOnCommand(lightLiving);

            LightOffCommand lightOffKitchen = new LightOffCommand(lightKitchen);
            LightOffCommand lightOffLiving = new LightOffCommand(lightLiving);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(sterio);
            StereoOnWithDVDCommand stereoOnWithDVD = new StereoOnWithDVDCommand(sterio);
            StereoOnWithRadioCommand stereoOnWithRadio = new StereoOnWithRadioCommand(sterio);
            StereoOff stereoOff = new StereoOff(sterio);

            /*
             * try push on/off button withiout bind
             */
            control.PushOnButton(0);
            control.PushOffButton(0);
            Console.WriteLine(); Console.WriteLine();

            /*
             * binding on/off buttons
             */
            control.setCommand(0, lightOnLiving, lightOffLiving);
            control.setCommand(1, lightOnKitchen, lightOffKitchen);
            control.setCommand(2, stereoOnWithCD, stereoOff);
            control.setCommand(3, stereoOnWithDVD, stereoOff);
            /*
             * print RemoteControl table
             */
            Console.WriteLine(control);
            Console.WriteLine();
            /*
             * On Lights
             */
            control.PushOnButton(0);
            control.PushOnButton(1);
            Console.WriteLine();
            /*
             * On Sterio CD and DVD
             */
            control.PushOnButton(2);
            control.PushOnButton(3);
            Console.WriteLine();
            /*
             * Off Lights
             */
            control.PushOffButton(0);
            control.PushOffButton(1);
            Console.WriteLine();
            /*
             * Off sterio CD button and DVD button
             */
            control.PushOffButton(2);
            control.PushOffButton(3);

            Console.ReadLine();
        }
    }
}