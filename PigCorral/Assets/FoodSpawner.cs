using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private NavMeshSurface2d m_NavMeshSurface;
    [SerializeField] private GameObject foodPrefab;
    private Bounds area;
    private void Start()
    {
        area = m_NavMeshSurface.navMeshData.sourceBounds;
        StartCoroutine(SpawnFood());
    }

    private IEnumerator SpawnFood()
    {
        while (true)
        {
            Vector3 randomPos = new Vector3(Random.Range(area.center.x, area.size.x), Random.Range(area.center.y, area.size.y));
            Instantiate(foodPrefab, randomPos, Quaternion.identity, transform);
            yield return new WaitForSeconds(3f);
        }
    }
}
