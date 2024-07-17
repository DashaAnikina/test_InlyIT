using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    Animator anim;

    Interact interact_class;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        interact_class = GetComponent<Interact>();
    }

    private void LateUpdate()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetBool("Walk", true);
        }
        else if (Input.GetAxis("Vertical") <= 0)
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (interact_class.interactable != null)
            {
                anim.SetBool(interact_class.interactable.getID().ToString(), true);
            }
        }
    }

    public void unlock()
    {
        anim.SetBool(interact_class.interactable.getID().ToString(), false);
    }
}
