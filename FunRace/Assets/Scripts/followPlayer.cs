using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    float smoothSpeed = 0.125f;
    public Vector3 offSet;

    private void FixedUpdate()
    {
        Vector3 desiredPos = new Vector3(transform.position.x ,target.position.y + offSet.y,target.position.z+offSet.z) ;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPos;
    }
}
