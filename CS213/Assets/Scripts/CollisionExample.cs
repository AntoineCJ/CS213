using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("colision between " + gameObject.name + " and " + collision.collider.name);
     //   print(collision.contactCount + " contacts");
     //   print("relative velocity " + collision.relativeVelocity);
    }

    private void OnCollisionStay(Collision collision)
    {
        print(gameObject.name + " and " + collision.collider.name + " are still colliding");
    }

    private void OnCollisionExit(Collision collision)
    {
        print(gameObject.name + " and " + collision.collider.name + " are no longer colliding");
    }
}

