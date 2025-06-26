using System;
using UnityEngine;

public class HelpCommand : ICommand
{
    public void Execute(string parameter)
    {
        Debug.Log("Se Ejecuto El Command Help");
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
