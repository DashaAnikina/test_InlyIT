using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum type { aptechka, bomb }

public abstract class i_object : MonoBehaviour
{
    public abstract type getType();

    public abstract void interact();
}
