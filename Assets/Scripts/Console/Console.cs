using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI consoleText;

    private void Awake()
    {
        inputField.onSubmit.AddListener(SubmitInput);

    }

    private void SubmitInput(string input)
    {
        consoleText.text = input;
        inputField.text = "";  
    }
}
