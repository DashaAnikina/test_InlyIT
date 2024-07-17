using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : i_object
{
    public override void interact()
    {
        Destroy(gameObject);
    }
}
