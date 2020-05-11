using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Shell : MonoBehaviour
{
    Transform transform;

    private void Start()
    {
        transform=GetComponent<Transform>();
        Destroy(gameObject,3);
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals("plane"))
        {
            Destroy(gameObject);
        }
    }
   
}
