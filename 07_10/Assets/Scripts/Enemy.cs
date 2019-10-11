using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;

    public float speed = 5f;

    [SerializeField]
    GameObject bullet;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void followTarget()
    {
        Vector3 input = target.position - transform.position;

        //normalizamos para pegar apenas a direção

        Vector3 direction = input.normalized;

        //nossa velocidade será a direção multiplicada pela nossa velocidade

        Vector3 velocity = direction * speed;

        //por fim a distância para percorrer será essa velocidade multiplicada pelo tempo

        Vector3 moveAmount = velocity * Time.deltaTime;

        //aqui iremos mover nosso jogador pela distância que iremos percorrer

        transform.Translate(moveAmount);

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
