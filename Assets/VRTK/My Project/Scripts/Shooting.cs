using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public float damage = 10f;

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Rigidbody hitBody = hit.collider.GetComponent<Rigidbody>();
            if (hitBody)
            {
                hitBody.AddForce(transform.forward * damage);
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * 10f);
    }
}
