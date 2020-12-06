using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    public Transform projectileSpawn;
    public GameObject prefab;
    public bool isEnabled = false;
    public float force = 20f;
    public bool isCard = false;
    private GameObject projectile;

    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && isEnabled)
        {
            Use();
        }
        
    }

    void Use()
    {

        projectile = Instantiate(prefab, projectileSpawn.position, projectileSpawn.rotation);

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        rb.AddForce(projectileSpawn.up * force, ForceMode2D.Impulse);

        if (isCard)
        {
            Invoke("splitCard", 0.5f);
            Destroy(projectile.gameObject, 0.5f);
        }

    }

    void splitCard()
    {
        projectile.GetComponent<split>().startSplit();
    }

}
