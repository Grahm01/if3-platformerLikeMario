using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
    public static LevelsManager instance = null;
    public GameObject playerPrefab;
    public GameObject player;
    public static int lifes = 3;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this; //instance == moi
            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public static void LoseLife()
    {
        lifes--;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(lifes);

        if (lifes <= 0)
        {
            SceneManager.LoadScene("GameOver");

        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
