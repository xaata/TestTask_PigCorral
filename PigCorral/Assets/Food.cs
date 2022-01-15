using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private BombManipulations bomb;
    private float timer = 0;
    private float foodLiveTime = 3f;
    private void Start()
    {
        bomb = GameObject.FindGameObjectWithTag("Player").GetComponent<BombManipulations>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bomb.AddBomb(2);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > foodLiveTime)
            Destroy(gameObject);
    }
}
