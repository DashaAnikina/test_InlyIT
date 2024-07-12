using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : i_object
{
    public override type getType()
    {
        return type.bomb;
    }

    public override void interact()
    {
        Destroy(this.gameObject);
    }
}
