using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour
{

    public Transform meleeSpawn;
    public GameObject meleePrefab;
    public GameObject player;
    public int swingSpeed = 400;
    private GameObject meleeObj = null;

    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && meleeObj == null)
        {
            Use();
        }
        if (meleeObj != null)
        {
            meleeObj.transform.position = meleeSpawn.position;
            meleeObj.transform.RotateAround(meleeSpawn.transform.position, Vector3.forward, swingSpeed * Time.deltaTime);
            player.transform.Rotate(new Vector3(0, 0, player.transform.rotation.eulerAngles.z));
        }
        
        
    }

    void Use()
    {
        meleeObj = Instantiate(meleePrefab, meleeSpawn.position, meleeSpawn.rotation);
        meleeObj.transform.Rotate(new Vector3(0, 0, -40));
        Destroy(meleeObj, 60f/swingSpeed);
    }
}
