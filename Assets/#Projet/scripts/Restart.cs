using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : SceneChanger
{
    //dans start LevelsManager.life = life
    private void Start()
    {
        LevelsManager.lifes = 3;
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);

        }
    }
}
