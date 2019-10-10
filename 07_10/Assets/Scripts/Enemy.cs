using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float timeDestroy = 5f;

    public Player player;

    void Start()
    {
        Destroy(gameObject, 3);
    }


    /*private void Die()
    {
        if(timeDestroy <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }*/
}
