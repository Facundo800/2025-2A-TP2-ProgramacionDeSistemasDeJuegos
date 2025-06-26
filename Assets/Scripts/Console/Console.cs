using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI consoleText;
    [SerializeField] private int amountOfLogs = 10;


    List<string> inputs = new List<string>();


    private void Awake()
    {
        inputField.onSubmit.AddListener(SubmitInput);

    }

    private void SubmitInput(string input)
    {
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
    }
}
