using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFind : MonoBehaviour

{
    [SerializeField]
    float interpolation;

    float timer = 0;
    float bridgeTimer = 0;

    public Transform[] endPoints;

    

    public Bridge bridge;

    
    List<Collider> pickupColliders = new List<Collider>();


    void Update()
    {

        if (Input.GetKey("f"))
        {
            // bring objects to the player
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 10);
            int i = 0;
            int endPointIndex = 0;

            

            pickupColliders.Clear();

            while (i < hitColliders.Length)
            {
                if (hitColliders[i].gameObject.tag == "Pickup")
                {
                    pickupColliders.Add(hitColliders[i]);

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

            bridgeTimer = 0;
        }
        else
        {
            if(bridge)
            {
                int endPointIndex = 0;
                foreach (var pickup in pickupColliders)
                {
                    if (endPointIndex < bridge.endPoints.Length)
                    {
                        pickup.gameObject.GetComponent<Rigidbody>().useGravity = false;
                        pickup.gameObject.transform.position = Vector3.Lerp(pickup.gameObject.transform.position, bridge.endPoints[endPointIndex].position, bridgeTimer * interpolation);
                        endPointIndex++;
                        
                    }
                    
                }
                bridgeTimer += Time.deltaTime;
                
            }
        }
    }
}


//disable ability to pickup stones within bridge sphere
//setup list of bridge end points so no two colliders can share the same point
