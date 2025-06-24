using System;
using UnityEngine;

public class PlayAnimationAction 
{
    public void Execute(string animation)
    {
        var characters = UnityEngine.Object.FindObjectsByType<CharacterAnimator>(FindObjectsInactive.Exclude,FindObjectsSortMode.None);
        foreach (var item in characters)
        {
            item.PlayAnimation(animation);
        }
    }

}