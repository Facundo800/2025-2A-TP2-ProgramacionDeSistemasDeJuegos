using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour, ILogHandler
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI consoleText;
    [SerializeField] private int amountOfLogs = 10;


    Dictionary<string,ICommand>commands = new Dictionary<string,ICommand>();

    private ILogHandler logHandler;


    private void Awake()
    {
        logHandler = Debug.unityLogger.logHandler;
        Debug.unityLogger.logHandler = this;
        inputField.onSubmit.AddListener(SubmitInput);
    }
    public Dictionary<string, ICommand> GetCommands() 
    {  
       return commands;
    } 
    private void SubmitInput(string input)
    {
        if (input == "") return;
        consoleText.text += input + "\n";
        inputField.text = "";
        string commandName = input.ToLower().Split(' ')[0];
        
        if (commands.TryGetValue(commandName, out var command))
        {
            string parameter = input.Split(' ').LastOrDefault();
            command.Execute(parameter);
        }

    }

    public void RegisterCommand(ICommand command)
    {
        foreach (var item in command.GetAliasses())
        {
            commands.Add(item.ToLower(), command);
        }
    }

    public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
    {
       string log = string.Format(format,args);
        consoleText.text += logType + " " + log + "\n";
        logHandler.LogFormat(logType, context, format, args);
    }

    public void LogException(Exception exception, UnityEngine.Object context)
    {
        consoleText.text += "[Exception] " + exception.Message + "\n";
        logHandler.LogException(exception, context);
    }

    public void Open()
    {
       gameObject.SetActive(!gameObject.activeSelf);
    }
}
