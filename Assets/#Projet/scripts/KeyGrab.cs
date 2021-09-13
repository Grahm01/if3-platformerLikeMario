using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrab : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            //Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            Debug.Log("aaa boum");
        }

    }
}
