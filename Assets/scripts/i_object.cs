using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class i_object : MonoBehaviour
{
    public string string_id;
    public string getID()
    {
        return string_id;
    }

    public abstract void interact();
}
