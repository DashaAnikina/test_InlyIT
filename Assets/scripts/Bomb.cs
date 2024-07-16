using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : i_object
{
    public override int getID()
    {
        return 3;
    }

    public override void interact()
    {
        Destroy(this.gameObject);
    }
}
