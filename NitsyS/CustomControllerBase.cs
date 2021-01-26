using Microsoft.AspNetCore.Mvc;
using System;

namespace NitsyS
{
    public class CustomControllerBase<T> : ControllerBase
    {
        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string prefix = $"[{typeof(T).Name}]";
            Console.WriteLine($"{prefix} {message}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}