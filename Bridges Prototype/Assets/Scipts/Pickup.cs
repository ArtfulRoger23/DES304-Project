using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public Transform endTrans;

    [SerializeField]
    float interpolation;

    float timer = 0;


    void Update()
    {
        if (Input.GetKey("f"))
        {
            
            GetComponent<Rigidbody>().useGravity = false;

            timer += Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, endTrans.position, timer * interpolation);

            //GameObject.Find("Destination").GetComponent<Transform>().position
        }


    }
}


