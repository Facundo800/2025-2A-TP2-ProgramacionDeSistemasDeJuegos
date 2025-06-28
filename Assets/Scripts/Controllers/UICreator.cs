using Assets.Scripts.Controllers;
using UnityEngine;

public class UICreator: MonoBehaviour
{
    [SerializeField] private UIControllerModel controllerModel;
    [SerializeField] private UIController controller;
    private void Awake()
    {
        controller.Setup(controllerModel);
    }
}