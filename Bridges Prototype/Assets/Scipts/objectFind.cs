using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFind : MonoBehaviour

{

    public Transform endTrans;

    [SerializeField]
    float interpolation;

    float timer = 0;


    void Update()
    {

        if (Input.GetKey("f"))
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 10);
            int i = 0;
            Transform nearest = null;
            float nearDist = 5;
            while (i < hitColliders.Length)
            {
                float thisDist = (transform.position - hitColliders[i].transform.position).sqrMagnitude;
                if (thisDist < nearDist)
                {
                    nearDist = thisDist;
                    nearest = hitColliders[i].transform;
                }
            }
            if (nearest != null)
            {
                GetComponent<Rigidbody>().useGravity = false;

                timer += Time.deltaTime;
                transform.position = Vector3.Lerp(transform.position, endTrans.position, timer * interpolation);
            }
        }
    }





}
