using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float range;
    public float movementSpeed;

    // Update is called once per frame

    void FixedUpdate()
    {
        Debug.Log(transform.position);
        if (Vector2.Distance(rb.position, new Vector2(player.transform.position.x, player.transform.position.y)) < range)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime);
            //sprite rotation
            Vector2 lookDir = new Vector2(transform.position.x, transform.position.y) - rb.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
        }
       
    }
}
