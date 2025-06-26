using System;
using UnityEngine;

public class AliassesCommand : ICommand
{
    public void Execute(string parameter)
    {
        Debug.Log("Se Ejecuto El Command Aliasses");
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
