using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int health_count = 50;

    public void HPchange(int count)
    {
        if (health_count + count >= 0 && health_count + count <= 100)
            health_count += count;
    }
}
