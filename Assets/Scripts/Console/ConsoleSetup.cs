using UnityEngine;

public class ConsoleSetup: MonoBehaviour
{
    [SerializeField] private Console Console;
    private void Start()
    {
        Console.RegisterCommand(new HelpCommand(Console.GetCommands()));
        Console.RegisterCommand(new AliassesCommand(Console.GetCommands()));
        Console.RegisterCommand(new PlayAnimationCommand());
    }
}