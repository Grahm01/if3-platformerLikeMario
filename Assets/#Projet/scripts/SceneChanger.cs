using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{

    void Update()
    {
    }

    public void Load()
    {       
            int index = SceneManager.GetActiveScene().buildIndex; //charge l'index de sc�ne suivante o/ et apr�s on load la sc�ne
            SceneManager.LoadScene(index + 1);
            //Debug.Log("ok I'm in");
        

    }
}


