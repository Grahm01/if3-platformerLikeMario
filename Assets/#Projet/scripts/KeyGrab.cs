using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyGrab : MonoBehaviour
{

    public UnityEvent whenPickUp;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            //Destroy(collision.collider.gameObject);

            Destroy(gameObject);
            Debug.Log("Key Picked up");
            whenPickUp?.Invoke();
        }

    }
}
