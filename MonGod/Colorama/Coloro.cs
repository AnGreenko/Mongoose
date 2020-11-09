using System;

namespace MonGod.Colorama
{
    public class Coloro
    {
        private bool AutoReset;

        public Coloro(bool autoReset)
        {
            AutoReset = autoReset;
        }
        
        public Coloro() : this(false) { }
        
        public void WriteLine(object message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            
            Console.WriteLine(message);

            Reset();
        }
        
        public void Write(object message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            
            Console.WriteLine(message);

            Reset();
        }

        public string ReadLine(object message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            
            Console.Write(message);
            
            string name = Console.ReadLine();

            Reset();

            return name;
        }

        private void Reset()
        {
            if (AutoReset)
            {
                Console.ResetColor();
            }
        }
    }
}