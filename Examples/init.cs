// created by me

// default libraries
using System;

// sets the static of imported Class and does not choose namespace
using static Init.LOGGER;


// sets namespace
namespace Init;




//Logging

// inherites the I_Init interface
//this is your class
public class LOGGER
{
    // creates a new void class with a message and a LOG Type
    public void Log(string message, LOGTYPE log)
    {
        // Switch Statement
        switch (log)
        {
            // Log
            case LOGTYPE.LOG: Console.WriteLine("LOG: " + message);
                break;

            // Warning
            case LOGTYPE.WARNING: Console.WriteLine("WARNING: " + message);
                break;

            // Error
            case LOGTYPE.ERROR: Console.WriteLine("ERROR: " + message);
                break;

            default:
                Console.WriteLine("No Logging Type");
                break;
        }
    }

    
    public enum LOGTYPE
    {
        LOG, // Normal Logging
        WARNING, // Warns of something wrong
        ERROR // Throws an Error when something breaks during initilizing or before a crash
    }
}

class Program
{
    // create an instance of LOGGER
    public static LOGGER logger = new();

    // assigns John Doe to Name string (Can not contain numbers)
    public static string Name = "John Doe";

    // main method, needs to be here to execute commands
    public static void Main(string[] args)
    {
        // Log, put a message and add a logtype
        logger.Log($"Player ID is {Name}", LOGTYPE.LOG);
        
    }
}
