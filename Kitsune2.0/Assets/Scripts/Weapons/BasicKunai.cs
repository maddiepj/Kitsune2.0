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
    public WeaponsManager weaponMgr;
    public GameObject kunaiPrefab;
    public Rigidbody2D rigidBody;
    public float timeBeforeDestroy = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeBeforeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public override void Throw()
    {
        rigidBody.velocity = transform.right * velocity;
    }

    public override void OnTriggerEnter2D()
    {
        Debug.Log("Enemy hit");
    }

}
