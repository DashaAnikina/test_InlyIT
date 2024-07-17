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

    Interact interact_class;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        interact_class = GetComponent<Interact>();
        StartCoroutine(WalkingCoroutine());
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StopCoroutine(WalkingCoroutine());

            if (interact_class.interactable != null)
            {
                interact_class.interact(interact_class.interactable);
            }
        }

        StartCoroutine(WalkingCoroutine());
    }

    IEnumerator WalkingCoroutine()
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

        yield return null;
    }
}


