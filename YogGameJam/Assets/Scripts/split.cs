using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class split : MonoBehaviour
{

    public GameObject splitPrefab;

    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag != "Player" && other.gameObject.tag != "Projectile")
        {
            GameObject.Find("Player").GetComponent<gun>().CancelInvoke();
            startSplit();
            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
        }
    }

    public void startSplit()
    {

        GameObject projectile1 = Instantiate(splitPrefab, transform.position, Quaternion.Euler(0, 0, 0));
        GameObject projectile2 = Instantiate(splitPrefab, transform.position, Quaternion.Euler(0, 0, 120));
        GameObject projectile3 = Instantiate(splitPrefab, transform.position, Quaternion.Euler(0, 0, 240));

        Rigidbody2D rb1 = projectile1.GetComponent<Rigidbody2D>();

        rb1.AddForce(new Vector3(-1, 1, 0) * 5f, ForceMode2D.Impulse);
        Rigidbody2D rb2 = projectile2.GetComponent<Rigidbody2D>();

        rb2.AddForce(new Vector3(1, 1, 0) * 5f, ForceMode2D.Impulse);
        Rigidbody2D rb3 = projectile3.GetComponent<Rigidbody2D>();

        rb3.AddForce(new Vector3(0, -1, 0) * 5f, ForceMode2D.Impulse);

        Destroy(projectile1, 2f);
        Destroy(projectile2, 2f);
        Destroy(projectile3, 2f);

    }
}
