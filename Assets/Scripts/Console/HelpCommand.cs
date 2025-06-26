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
        if (commands.TryGetValue(parameter, out var command))
        {
            Debug.Log(parameter + " " + command.GetDescription());
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
        return "Get Description From A Command";
    }
}
