using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentController : MonoBehaviour
{
    Transform ParentTurrent;
    public Transform turrent;

    public float turrentaim = 1f;
    int aimup = -1, aimdown = 1;

    private void Awake()
    {
        ParentTurrent = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ParentTurrent.eulerAngles);

        if (Input.GetKey(KeyCode.A))
        {
            ParentTurrent.Rotate(0,-1,0);
        }else if(Input.GetKey(KeyCode.D))
        {
            ParentTurrent.Rotate(0, 1, 0);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {  
            if(turrent.eulerAngles.x > 335 || turrent.eulerAngles.x == 0 )
            {
                turrent.Rotate(-1, 0, 0);
            }
        }else if(Input.GetKey(KeyCode.LeftControl))
        {
            if (turrent.eulerAngles.x < 358)
            {
                 turrent.Rotate(1,0, 0);
            } 
        }



       /* if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log(turrent.localEulerAngles.x);
            if (turrent.localEulerAngles.x > 335 && turrent.localEulerAngles.x < 360)
            {
                turrent.Rotate(aimup * turrentaim, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
          //  Debug.Log(turrent.localEulerAngles.x);
            if (turrent.localEulerAngles.x >= 330 && turrent.localEulerAngles.x < 358)
            {
                turrent.Rotate(aimdown * turrentaim, 0, 0);
            }
        }*/
    }
}
