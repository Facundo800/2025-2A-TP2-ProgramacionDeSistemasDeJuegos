using System;
using UnityEngine;
using System.Collections.Generic;
public class AliassesCommand : ICommand
{
    private readonly Dictionary<string, ICommand> commands;

    public AliassesCommand(Dictionary<string, ICommand> commands)
    {
        this.commands = commands;
    }
    public void Execute(string parameter)
    {
        if (commands.TryGetValue(parameter, out var command))
        {
            Debug.Log("Aliasses For: " + parameter + " -> " + GetAliasses(command));
        }
    }

    private static string GetAliasses(ICommand command)
    {
        return string.Join(", ", command.GetAliasses());
    }

    public string[] GetAliasses()
    {
        return new string[] 
        {
            "Aliass","Alias","Aliasses","Aliases"
        };
    }

    public string GetDescription()
    {
        return "Get Aliasses From A Command";
    }
}
