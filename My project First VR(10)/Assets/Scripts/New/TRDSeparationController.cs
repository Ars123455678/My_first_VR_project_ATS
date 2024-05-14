using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRDSeparationContorller : MonoBehaviour, IInteractable
{
    public HoldableComponent[] allComponents;

    public Transform ts;

    private int pointer;

    public void Enter(Player player)
    {

    }

    public void Exit(Player player)
    {

    }

    public void Interact(Player player)
    {
        if (player.componentHolder.currentComponent.num == pointer)
        { 
            player.componentHolder.Set();
            pointer++;
        }

        if (player.componentHolder.currentComponent.num == -1)
        {
            player.componentHolder.Set();
        } 
    }

    public void Disassemble()
    {
        foreach (var component in allComponents)
        {
            component.OnPut();
        }
    }

    private void Start()
    {
        ts = transform;
    }
}
