using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    float smoothSpeed = 0.125f;
    public Vector3 offSet;
    public gameManager manager;
    public Vector3 pOffset;
    public Vector3 rOffset;

    private void Start()
    {
       
    }
    


    private void FixedUpdate()
    {
        if (manager.gameHasEnded != true )
        {
            Vector3 desiredPos = new Vector3(transform.position.x, target.position.y + offSet.y, target.position.z + offSet.z);
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
            transform.position = smoothedPos;
        }

        if(manager.gameHasEnded)
        {
            Debug.Log("Game Has Ended");

            
            if (transform.rotation.y < 180)
            {
                transform.parent.Rotate(0, Time.deltaTime * 100, 0);
            }
        }
    }
}
