﻿namespace Design_Patterns.Behavioral.ChainofResponsibility
{
    internal class WarnLogger:Logger
    {
        public WarnLogger(int level)
        {
            _level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("WARN :: "+message);
        }
    }
}
