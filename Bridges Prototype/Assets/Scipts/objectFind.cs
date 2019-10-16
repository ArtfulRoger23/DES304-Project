using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFind : MonoBehaviour

{
    [SerializeField]
    float interpolation;

    float timer = 0;

    public Transform[] endPoints;


    void Update()
    {

        if (Input.GetKey("f"))
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 10);
            int i = 0;
            int endPointIndex = 0;

            while (i < hitColliders.Length)
            {
                if (hitColliders[i].gameObject.tag == "Pickup")
                {
                    if (endPointIndex < endPoints.Length)
                    {
                        hitColliders[i].gameObject.GetComponent<Rigidbody>().useGravity = false;
                        hitColliders[i].gameObject.transform.position = Vector3.Lerp(hitColliders[i].gameObject.transform.position, endPoints[endPointIndex].position, timer * interpolation);
                        endPointIndex++;
                    }
                }

                // move on to next collider
                i++;
            }

            timer += Time.deltaTime;
        }
    }
}
