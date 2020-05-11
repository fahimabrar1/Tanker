using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public float turrentaim = 1f;
    public GameObject turrent,shell;
    public Transform firepoint;
   Transform checkr;

    int aimup = -1, aimdown = 1;
    bool tankalive;
    private void Start()
    {
        tankalive = true;
        StartCoroutine(FireShell()); ;
        Debug.Log(turrent.transform.localEulerAngles);
    }
    private void FixedUpdate()
    {
        firepoint.transform.rotation = transform.rotation;
        float translate = Input.GetAxis("Vertical") * speed;
        float rotational = Input.GetAxis("Horizontal") * rotationSpeed;

        translate *= Time.deltaTime;
        rotational *= Time.deltaTime;

        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotational, 0);

       
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log( turrent.transform.localEulerAngles.x);
            if (turrent.transform.localEulerAngles.x > 335 && turrent.transform.localEulerAngles.x < 360 )
            {
                turrent.transform.Rotate(aimup * turrentaim, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            Debug.Log(turrent.transform.localEulerAngles.x);
            if (turrent.transform.localEulerAngles.x >= 330 && turrent.transform.localEulerAngles.x < 358 )
            {
                turrent.transform.Rotate(aimdown * turrentaim, 0, 0);
            }
        }
    }

    IEnumerator FireShell()
    {
        while(tankalive)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(shell, firepoint.position, firepoint.rotation);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
