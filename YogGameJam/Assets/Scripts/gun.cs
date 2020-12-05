using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    public Transform projectileSpawn;
    public GameObject projectilePrefab;

    public float force = 20f;

    void Update()
    {
        /*
        if (Input.GetButtonDown("Fire1"))
        {
            Use();
        }
        */
    }

    void Use()
    {

        GameObject projectile = Instantiate(projectilePrefab, projectileSpawn.position, projectileSpawn.rotation);

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        rb.AddForce(projectileSpawn.up * force, ForceMode2D.Impulse);

    }
}
