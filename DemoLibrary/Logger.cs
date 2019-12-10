﻿using System;
namespace DemoLibrary
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged to Console: { message }");
        }
    }
}
