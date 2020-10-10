using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : Weapon
{
    public float velocity = 1f;
    public string weaponName = "Shuriken";
    public AudioClip throwSound = null;
    public float coolDownLength = 5;
    public int damage = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Throw()
    {
        Instantiate(projectilePrefab, throwPoint.position, throwPoint.rotation);
    }
}
