using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombModule : Modules
{
    public BombModule(Interact interact) : base(interact)
    {
    }

    public override void interactive(i_object interactable)
    {
        if (interactable.getID() == "bomb")
        {
            interact.HP_count(-10);
            interactable.interact();
            interact.HP_text();
            interact.help_panel_close();
            interact.Invoke("ObjectNull", 2);
        }
    }
}