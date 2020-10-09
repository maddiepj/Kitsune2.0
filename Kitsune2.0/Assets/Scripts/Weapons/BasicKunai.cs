using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicKunai : Weapon
{

    public float velocity = 1f;
    public string weaponName = "Kunai";
    public AudioClip throwSound = null;
    public float coolDownLength = 0;
    public int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Behavior()
    {
        // damage enemy
    }
}
