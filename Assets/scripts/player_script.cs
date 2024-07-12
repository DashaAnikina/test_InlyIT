using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class player_script : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;

    public float walk_speed = 10;
    float speed = 0;

    bool action = false;

    public TMP_Text health_count_txt;
    public int health_count = 50;

    public GameObject help_panel;
    [HideInInspector]
    public i_object interactable = null;

    List<Modules> modules = new List<Modules>();

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        help_panel.SetActive(false);
        health_count_txt.text = health_count.ToString();

        modules.Add(new AptechkaModule(this));
        modules.Add(new BombModule(this));
    }

    void LateUpdate()
    {
        if (action == false)
        {
            walking();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if (interactable != null)
            {
                interact(interactable);
            }
        }
    }

    public void interact(i_object interactable)
    {
        foreach (Modules m in modules)
        {
            m.interact(interactable);
            
        }
        if (interactable.getType() == type.aptechka)
        {
            speed = 0;
            action = true;
            anim.SetInteger("State", 2);
        }
        else if (interactable.getType() == type.bomb)
        {
            speed = 0;
            action = true;
            anim.SetInteger("State", 3);
        }

    }

    public void HPchange(int count)
    {
        if (health_count + count >= 0 && health_count + count <= 100)
            health_count += count;
    }

    private void OnTriggerEnter(Collider other)
    {
        interactable = other.GetComponent<i_object>();

        if (other.GetComponent<i_object>() != null)
        {
            help_panel.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<i_object>() != null)
        {
            help_panel.SetActive(false);
            interactable = null;
        }
    }

    
    public void walking()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetInteger("State", 1);
            speed = walk_speed;

        }
        else if (Input.GetAxis("Vertical") <= 0)
        {
            anim.SetInteger("State", 0);
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

    public void unlock()
    {
        action = false;
    }
}


