using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text bombCountText;
    private bool lose = false;
    private bool win = false;
    private int bombCount = 5;
    

    public int BombCount{
            get => bombCount;
        set
        {
            
            bombCount = value;
            if (bombCount < 0)
                GameOver();
            if (bombCount > 20)
                Win();
            bombCountText.text = bombCount.ToString();
            
        }
    }
    private void GameOver()
    {
        if (!lose)
        {
            lose = true;
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

    }
    private void Win()
    {
        if (!win)
        {
            win = true;
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
