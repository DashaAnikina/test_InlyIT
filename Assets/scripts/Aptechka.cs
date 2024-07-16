using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aptechka : i_object
{
    public override int getID()
    {
        return 2;
    }

    public override void interact()
    {
        Destroy(this.gameObject);
    }
}
