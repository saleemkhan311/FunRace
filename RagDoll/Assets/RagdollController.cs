using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    public CapsuleCollider mainCollider;
    public GameObject Rig;
    public Animator anim;


    void RagDollModeOn()
    {
        anim.enabled = false;
        foreach (Collider collider in RagDollColliders)
        {
            collider.enabled = true;
        }

        foreach (Rigidbody rb in LimbsRigidBodies)
        {
            rb.isKinematic = false;
        }

        
        mainCollider.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            RagDollModeOn();
        }
    }

    Collider[] RagDollColliders;
    Rigidbody[] LimbsRigidBodies;
    void GetRagDollBits()
    {
        RagDollColliders = Rig.GetComponentsInChildren<Collider>();
        LimbsRigidBodies = Rig.GetComponentsInChildren<Rigidbody>();
    }

    void RagDollModeOff()
    {
        foreach(Collider collider in RagDollColliders)
        {
            collider.enabled = false;
        }

        foreach(Rigidbody rb in LimbsRigidBodies)
        {
            rb.isKinematic = true;
        }

        anim.enabled = true;
        mainCollider.enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }

    private void Start()
    {
        GetRagDollBits();
        RagDollModeOff();
    }
}
