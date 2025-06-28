using System;
using UnityEngine;
using System.Collections.Generic;

public class HelpCommand : ICommand
{
    private readonly Dictionary<string, ICommand> commands;

    public HelpCommand(Dictionary<string, ICommand> commands)
    {
        this.commands = commands;
    }
    public void Execute(string parameter)
    {
        string lowerParameter = parameter.ToLower(); 
        if (commands.TryGetValue(lowerParameter, out var command))
        {
            Debug.Log("Command: " + lowerParameter + " -> " + command.GetDescription());
        }
        else 
        {
            if (lowerParameter == "")
            {
                Debug.Log("Command Name Required");
            }
            else
            {
                Debug.Log("Command Not Found: " + lowerParameter);
            }
        }
    }

    public string[] GetAliasses()
    {
        return new string[]
        {
            "Help","H",
        };
    }

    public string GetDescription()
    {
        return "Help [command]: Get Description From A Command";
    }
}
