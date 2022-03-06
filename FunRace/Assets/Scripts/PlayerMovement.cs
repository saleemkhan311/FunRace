using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float speed = 5;
    Vector3 move;
    Rigidbody rb;
    public gameManager manager;
    public Transform startPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = startPoint.position;
    
        
    }
    void FixedUpdate()
    {
        
        
        if(Input.GetMouseButton(0) && manager.gameHasEnded ==false)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
       


    }

    
    void OnMouseDown()
    {
       if(manager.gameHasEnded == false)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        }
    }

    void OnMouseDrag()
    {
        
        if(manager.gameHasEnded == false)
        {
            Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
            transform.position = new Vector3(cursorPosition.x, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > 2)
        {
            transform.position = new Vector3(2, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -2)
        {
            transform.position = new Vector3(-2, transform.position.y, transform.position.z);
        }
    }

    

}
