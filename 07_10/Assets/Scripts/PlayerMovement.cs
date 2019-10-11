using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public LayerMask layerMask;

    NavMeshAgent nv;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        nv = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            moviment();
        }
    }

    void moviment()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;

        if (Physics.Raycast(ray, out raycastHit, 200, layerMask))
        {
            nv.SetDestination(raycastHit.point);
        } 
    }
}
