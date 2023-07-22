using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    MeshRenderer renderer;
    Rigidbody rigidBody;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }

    }
}
