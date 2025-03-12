using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330138
{
    public class FanLaptop
    {
        enum State {Quiet, Balanced, Performance, Turbo };

        public void Run()
        {
            State state = State.Quiet;
            string[] screenName = { "Quiet", "Balanced", "Performance", "Turbo" };

            while (true)
            {
                Console.WriteLine("State saat ini : " + screenName[(int)state]);
                Console.Write("Masukan Command : ");

                string command = Console.ReadLine();

                switch (state)
                {
                    case State.Quiet:
                        if(command == "Mode Up")
                        {
                            state = State.Balanced;
                        } else if(command == "Turbo Shortcut")
                        {
                            state = State.Turbo;
                        }
                        break;

                    case State.Balanced:
                        if (command == "Mode Up")
                        {
                            state = State.Performance;
                        }
                        else if (command == "Mode Down")
                        {
                            state = State.Quiet;
                        }
                        break;

                    case State.Performance:
                        if (command == "Mode Up")
                        {
                            state = State.Turbo;
                        }
                        else if (command == "Mode Down")
                        {
                            state = State.Balanced;
                        }
                        break;

                    case State.Turbo:
                        if (command == "Mode Down")
                        {
                            state = State.Performance;
                        }
                        else if (command == "Turbo Shortcut")
                        {
                            state = State.Quiet;
                        }
                        break;
                }
            }
        }
    }
}
