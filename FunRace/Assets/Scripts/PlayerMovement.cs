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
    void Start()
    {
        //controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    
        
    }
    void FixedUpdate()
    {
        Vector3 newCamPos = new Vector3(0, 6.0f, -8.0f);
        //cam.transform.position = new Vector3(cam.transform.position.x, transform.position.y + newCamPos.y, transform.position.z + newCamPos.z);

        Vector3 a = Vector3.zero;
        transform.rotation = Quaternion.identity;
        move = new Vector3(a.x, 0, Input.GetAxis("Fire1"));
        
        if(Input.GetMouseButton(0))
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
       


    }

    
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = new Vector3(cursorPosition.x,transform.position.y,transform.position.z);
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
