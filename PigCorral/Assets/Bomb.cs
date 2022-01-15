using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bomb : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    float stunDuration = 2f;
    bool isStunned = false;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            navMeshAgent = collider.gameObject.GetComponent<NavMeshAgent>();
            StunApply();
        }
    }

    private void StunApply()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        navMeshAgent.GetComponent<SpriteRenderer>().color = Color.red;
        navMeshAgent.isStopped = true;
        isStunned = true;                 
    }
    private void StunRemove()
    {
        navMeshAgent.isStopped = false;
        navMeshAgent.GetComponent<SpriteRenderer>().color = Color.white;
        isStunned = false;
        Destroy(gameObject);
    }

    private void Update()
    {
        if (isStunned)
        {
            stunDuration -= Time.deltaTime;
            if (stunDuration <= 0)
                StunRemove();
        }        
    }
}
