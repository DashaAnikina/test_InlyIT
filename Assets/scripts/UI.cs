using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text health_count_txt;
    public GameObject help_panel;

    // Start is called before the first frame update
    void Start()
    {
        help_panel.SetActive(false);
        health_count_txt.text = GetComponent<HP>().health_count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
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
        }
    }
}
