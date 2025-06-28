using System;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public class UIControllerModel : IUIControllerModel
{
    [field: SerializeField] public InputActionReference OpenConsole { get; set; } 
}
