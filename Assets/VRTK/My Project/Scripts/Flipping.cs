using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipping : MonoBehaviour
{
    public GameObject Pancake;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FLipThePancake(float Power)
    {
        rb.AddForce(Vector3.up * Power);
    }
}
