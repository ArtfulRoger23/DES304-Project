﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bridge : MonoBehaviour
{

    public Transform[] endPoints;
    public GameObject Release_Text;


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<objectFind>().bridge = this;
            Release_Text.SetActive(true);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<objectFind>().bridge = null;
            Release_Text.SetActive(false);
        }
    }

}
