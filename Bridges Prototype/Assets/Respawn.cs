using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject playerFPSController;
    public GameObject respawnPoint;


    private CharacterController charController;

    void OnTriggerEnter(Collider other)
    {
        charController = GetComponent<CharacterController>();

        playerFPSController.GetComponent<CharacterController>().enabled = false;
        playerFPSController.GetComponent<CharacterController>().transform.position = respawnPoint.transform.position;
        playerFPSController.GetComponent<CharacterController>().enabled = true;

    }
}
