using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Controllers
{
    public class UIController: MonoBehaviour
    {
        public IUIControllerModel Model;
        public Console Console;
        public void Setup(IUIControllerModel model)
        {
            Model = model;
            if (Model.OpenConsole?.action != null)
                Model.OpenConsole.action.performed += HandleOpenInput;
        }

        private void HandleOpenInput(InputAction.CallbackContext context)
        {
            Console.Open();
        }

        private void OnDisable()
        {
            if (Model.OpenConsole?.action != null)
                Model.OpenConsole.action.performed -= HandleOpenInput;
        }
    }
}
