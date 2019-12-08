using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTut : MonoBehaviour
{

    public GameObject Pickup_Text;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Pickup_Text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<objectFind>().bridge = null;
            Pickup_Text.SetActive(false);
        }
    }
}
