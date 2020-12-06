using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag != "Player" && other.gameObject.tag != "Projectile")
        {
            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
        }
           
    }
}
