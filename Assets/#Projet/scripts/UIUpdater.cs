using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public Image[] lifeImages;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int index =0; index < lifeImages.Length; index++)
        {
            lifeImages[index].enabled = index < LevelsManager.lifes; //images qui aparaissent si lifes >3 etc etc
        }

        
    }
}
