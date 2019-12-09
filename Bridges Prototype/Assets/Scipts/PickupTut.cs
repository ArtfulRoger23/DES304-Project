using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTut : MonoBehaviour
{

    public GameObject TutText;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TutText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<objectFind>().bridge = null;
            TutText.SetActive(false);
        }
    }
}
