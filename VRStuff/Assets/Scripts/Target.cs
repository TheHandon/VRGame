using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Target : MonoBehaviour
{
    public int collisionLayer;
    
    private void OnCollisionEnter(Collision collision)
    {
        if ((LayerMask)(collision.collider.gameObject.layer) == collisionLayer)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
