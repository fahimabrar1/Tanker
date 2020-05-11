using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class AiTanker : MonoBehaviour
{

    public GameObject shell;
    public Transform firepoint,rotationalturrent;
    NavMeshAgent tank;
    
    bool tankalive;
    private void Awake()
    {
        tank = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        tankalive = true;
        StartCoroutine(FireShell()); ;

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit, 100))
            {
                tank.SetDestination(hit.point);
            }
        }
    }

    IEnumerator FireShell()
    {
        while (tankalive)
        {
            if (Input.GetMouseButton(1))
            {
                Instantiate(shell, firepoint.position, firepoint.rotation);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
