using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Modules
{
    public player_script ps;

    public Modules(player_script ps)
    {
        this.ps = ps;
    }

    public abstract void interact(i_object interactable);
}

public class BombModule : Modules
{
    public BombModule(player_script ps):base(ps)
    {
    }

    public override void interact(i_object interactable)
    {
        if(interactable.getType() == type.bomb)
        {
            ps.HPchange(-10);
            interactable.interact();
            ps.interactable = null;
            ps.health_count_txt.text = ps.health_count.ToString();
            ps.help_panel.SetActive(false);
        }
    }
}

public class AptechkaModule : Modules
{
    public AptechkaModule(player_script ps) : base(ps)
    {
    }

    public override void interact(i_object interactable)
    {
        if (interactable.getType() == type.aptechka)
        {
            ps.HPchange(5);
            interactable.interact();
            ps.interactable = null;
            ps.health_count_txt.text = ps.health_count.ToString();
            ps.help_panel.SetActive(false);
        }
    }
}