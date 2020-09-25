﻿using System;

namespace Learning_C_Sharp
{
    class Program  
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");          
            Console.WriteLine(comp.Os.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.Os = OS.getInstance("Windows 10");
            Console.WriteLine(comp.Os.Name);

            Console.ReadLine();
        }
    }
    class Computer
    {
        public OS Os { get; set; }
        public void Launch(string osName)
        {
            Os = OS.getInstance(osName);
        }
    }
    class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
}
