using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Modules
{
    public Interact interact;

    public Modules(Interact interact)
    {
        this.interact = interact;
    }

    public abstract void interactive(i_object interactable);
}