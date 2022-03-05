using System;

namespace Threat_Safe_SingletonDesignPattern
{
    public sealed  class Singleton
    {
        private static int counter = 0; 
        private static readonly object InstantLock = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Vale of counter: {counter}");
        }
        private static Singleton Instance = null;
        public static Singleton GetSingletonInstance
        {
            get
            {
                lock (InstantLock)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
                return Instance; 
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
   


}
