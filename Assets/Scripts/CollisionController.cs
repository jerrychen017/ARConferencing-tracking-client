using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    // make the colliding game object semi-transparent
    void OnTriggerEnter(Collider other)
    {
        Color color = other.gameObject.GetComponent<Renderer>().material.color;
        color.a = 0.5f;
        other.gameObject.GetComponent<Renderer>().material.color = color;
    }

    // remove the semi-transparency when not colliding
    void OnTriggerExit(Collider other)
    {
        Color color = other.gameObject.GetComponent<Renderer>().material.color;
        color.a = 1.0f;
        other.gameObject.GetComponent<Renderer>().material.color = color;
    }
}
