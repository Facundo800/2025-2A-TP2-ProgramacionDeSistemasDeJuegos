using System;
using UnityEngine;

public class PlayAnimationCommand : ICommand
{
    public void Execute(string animation)
    {
        var characters = UnityEngine.Object.FindObjectsByType<CharacterAnimator>(FindObjectsInactive.Exclude,FindObjectsSortMode.None);
        foreach (var item in characters)
        {
            item.PlayAnimation(animation);
        }
        Debug.Log("Se Ejecuto El Command PlayAnimation");
    }
    public string[] GetAliasses()
    {
        return new string[]
        {
            "PlayAnimation","Play","P",
        };
    }

    public string GetDescription()
    {
        return "PlayAnimation From All Characters";
    }

}