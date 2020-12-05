using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 currentPos;
    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        currentPos.x = transform.position.x;
        currentPos.y = transform.position.y;

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {

        //player sprite rotation
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

        //player movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //cam movement
        cam.transform.position = new Vector3(currentPos.x + lookDir.x/5, currentPos.y + lookDir.y/5, -10f);
    }
}
