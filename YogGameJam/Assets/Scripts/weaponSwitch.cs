using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSwitch : MonoBehaviour
{

    private melee meleeScript;
    private gun gunScript;
    public GameObject[] weapons;
    public bool[] unlocks;


    void Start()
    {
        meleeScript = GetComponent<melee>();
        gunScript = GetComponent<gun>();

    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1) && unlocks[0])
        {
            meleeScript.prefab = weapons[0];
            meleeScript.isEnabled = true;
            gunScript.isEnabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && unlocks[1])
        {
            meleeScript.prefab = weapons[1];
            meleeScript.isEnabled = false;
            gunScript.isEnabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && unlocks[2])
        {
            gunScript.prefab = weapons[2];
            meleeScript.isEnabled = false;
            gunScript.isEnabled = true;
            gunScript.force = 20f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && unlocks[3])
        {
            gunScript.prefab = weapons[3];
            meleeScript.isEnabled = false;
            gunScript.isEnabled = true;
            gunScript.force = 5f;
            gunScript.isCard = true;
        }
        
    }
}
