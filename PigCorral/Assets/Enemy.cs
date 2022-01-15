using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private BombManipulations bomb;

    private void Start()
    {
        bomb = GameObject.FindGameObjectWithTag("Player").GetComponent<BombManipulations>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bomb.ReduseBomb(3);
        }
    }


}
