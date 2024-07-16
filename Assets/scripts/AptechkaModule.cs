using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AptechkaModule : Modules
{
    public AptechkaModule(Interact interact) : base(interact)
    {
    }

    public override void interactive(i_object interactable)
    {
        if (interactable.getID() == 2)
        {
            interact.HP_count(5);
            interactable.interact();
            interact.interactable = null;
            interact.HP_text();
            interact.help_panel_close();
        }
    }
}
