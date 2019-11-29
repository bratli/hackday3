using System.Collections.Generic;

namespace HackDayRobot
{
    public class Input
    {
        public Start Start { get; set; }
        public List<Command> Commands { get; set; } 
    }

    public class Command
    {
        public string Direction { get; set; }
        public int Steps { get; set; }
    }

    public class Start
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
