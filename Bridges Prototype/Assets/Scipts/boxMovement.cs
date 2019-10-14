using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMovement : MonoBehaviour
{
    
    public Transform startTransform;
    
    public Transform endTransform;

    Vector3 startPos;
    Vector3 endPos;

    public bool triggered;

    [SerializeField]
    float interpolation;

    float timer = 0;
    private void Start()
    {
        
        startPos = startTransform.position;
        endPos = endTransform.position;
       
    }

    private void Update()
    {
        if (Input.GetKey("e")) { triggered = true; }

        if(triggered)
            {
                timer += Time.deltaTime;
                transform.position = Vector3.Lerp(startPos, endPos, timer * interpolation);
            }
    }
}
