using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public gameManager manager;
    Transform endPoint;
    
    
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        endPoint = manager.endPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.z >= endPoint.position.z-2)
        {

            manager.gameHasEnded = true;
            
        }
    }
    void Throw()
    {
        
        float randomDirection = Random.Range(-1000, 1000) * Time.deltaTime;
        rb.AddForce(randomDirection, 1000*Time.deltaTime, randomDirection);
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            manager.Restart();
            Throw();
            
        }
    }
}
