using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleComand
{
    class RemoteControl
    {
        ICommand[] commandOn;
        ICommand[] commandOff;
        ICommand undocommand;
        UInt16 max_slot = 0;

        public RemoteControl(UInt16 coutn_switch)
        {
            commandOn = new ICommand[coutn_switch];
            commandOff = new ICommand[coutn_switch];
            max_slot = coutn_switch;
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < coutn_switch; i++)
            {
                commandOn[i] = noCommand;
                commandOff[i] = noCommand;
            }
        }

        public void Undo() {
            undocommand.undo();
        }

        public void setCommand(int slot, ICommand c_on, ICommand c_off)
        {
            if (slot < max_slot)
            {
                commandOn[slot] = c_on;
                commandOff[slot] = c_off;
            }
        }

        public void PushOnButton(int slot)
        {
            if (slot < max_slot)
            {
                commandOn[slot].execute();
                undocommand = commandOn[slot];
            }
        }

        public void PushOffButton(int slot)
        {
            if (slot < max_slot)
            {
                commandOff[slot].execute();
                undocommand = commandOff[slot];
            }
        }


        public override String ToString()
        {
            string result = "\n------ Remote Control -------";
            for (int i = 0; i < max_slot; i++)
            {
                result += "\n" + commandOn[i].GetType().ToString();
                result += "\t\t\t" + commandOff[i].GetType().ToString();
            }
            return result;
        }

    }
}
