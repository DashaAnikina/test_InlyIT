using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    List<Modules> modules = new List<Modules>();

    [HideInInspector]
    public i_object interactable = null;

    // Start is called before the first frame update
    void Start()
    {
        modules.Add(new BombModule(this));
        modules.Add(new AptechkaModule(this));
    }

    public void interact(i_object interactable)
    {
        foreach (Modules m in modules)
        {
            m.interactive(interactable);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        interactable = other.GetComponent<i_object>();
    }

    private void OnTriggerExit(Collider other)
    {
        interactable = null;
    }

    public void HP_count(int count)
    {
        GetComponent<HP>().HPchange(count);
    }

    public void HP_text()
    {
        GetComponent<UI>().health_count_txt.text = GetComponent<HP>().health_count.ToString();
    }
    public void help_panel_close()
    {
        GetComponent<UI>().help_panel.SetActive(false);
    }
}
