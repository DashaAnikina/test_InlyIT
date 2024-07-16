using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    Animator anim;
    [HideInInspector]
    public bool action = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void LateUpdate()
    {
        if (action == false)
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                anim.SetInteger("State", 1);
            }
            else if (Input.GetAxis("Vertical") <= 0)
            {
                anim.SetInteger("State", 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GetComponent<Interact>().interactable != null)
            {
                if (GetComponent<Interact>().interactable.getID() == 2)
                {
                    GetComponent<player_script>().speed = 0;
                    action = true;
                    anim.SetInteger("State", 2);
                }
                else if (GetComponent<Interact>().interactable.getID() == 3)
                {
                    GetComponent<player_script>().speed = 0;
                    action = true;
                    anim.SetInteger("State", 3);
                }
            }
        }
    }

    public void unlock()
    {
        action = false;
    }
}
