using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aptechka : i_object
{
    public override type getType()
    {
        return type.aptechka;
    }

    public override void interact()
    {
        Destroy(this.gameObject);
    }
}
