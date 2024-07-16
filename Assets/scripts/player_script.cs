using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class player_script : MonoBehaviour
{
    
    Rigidbody rb;

    public float walk_speed = 10;

    [HideInInspector]
    public float speed = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        if (GetComponent<Anim>().action == false)
        {
            walking();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GetComponent<Interact>().interactable != null)
            {
                GetComponent<Interact>().interact(GetComponent<Interact>().interactable);
            }
        }
    }

    public void walking()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            speed = walk_speed;
        }
        else if (Input.GetAxis("Vertical") <= 0)
        {
            speed = 0;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, 90 * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 90 * Time.deltaTime, Space.Self);
        }

        rb.MovePosition(transform.position + (transform.forward * Time.deltaTime * speed));
    }

    
}


