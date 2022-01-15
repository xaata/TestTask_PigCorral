using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManipulations : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab;
    private Collider2D bomb;
    private Player player;
    private bool bombFound = false;
    private void Start()
    {
        player = GetComponent<Player>();
    }
    public void PickUpBomb()
    {
        if (bombFound)
        {
            Destroy(bomb.gameObject);
            player.BombCount++;
        }       
    }

    public void SetBomb()
    {
        if (player.BombCount > 0)
        {
            Instantiate(bombPrefab, transform.position, Quaternion.identity);
            player.BombCount--;
        }
        else Debug.Log("Out of bomb");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bomb"))
        {
            bomb = collision;
            bombFound = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Bomb"))
        {
            bomb = null;
            bombFound = false;
        }
    }
    public void ReduseBomb(int bombCount)
    {
        player.BombCount -= bombCount;
        GetComponent<SpriteRenderer>().color = Color.red;
        Invoke("ReturnColor", 0.3f);//magic num by ultra colstyl
    }
    public void AddBomb(int bombCount)
    {
        player.BombCount += bombCount;
        GetComponent<SpriteRenderer>().color = Color.green;
        Invoke("ReturnColor", 0.3f);//magic num by ultra colstyl
    }
    private void ReturnColor()//кошмарный костыль ))0)
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
