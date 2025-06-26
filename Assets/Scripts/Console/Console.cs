using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI consoleText;
    [SerializeField] private int amountOfLogs = 10;


    Dictionary<string,ICommand>commands = new Dictionary<string,ICommand>();

    List<string> inputs = new List<string>();


    private void Awake()
    {
        inputField.onSubmit.AddListener(SubmitInput);
        RegisterCommand(new HelpCommand(commands));
        RegisterCommand(new AliassesCommand(commands));
        RegisterCommand(new PlayAnimationCommand());
    }
    private void SubmitInput(string input)
    {
        if (input == "") return;
        inputs.Add(input);
        if (inputs.Count > amountOfLogs)
            inputs.RemoveAt(0);
        string output = "";
        foreach (var item in inputs)
        {
            output += item + "\n";
        }
        consoleText.text = output;
        inputField.text = "";
        string commandName = input.ToLower().Split(' ')[0];
        
        if (commands.TryGetValue(commandName, out var command))
        {
            string parameter = input.ToLower().Split(' ').LastOrDefault();
            command.Execute(parameter);
        }

    }

    private void RegisterCommand(ICommand command)
    {
        foreach (var item in command.GetAliasses())
        {
            commands.Add(item.ToLower(), command);
        }
    }

}
