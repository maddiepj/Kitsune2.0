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
    public Rigidbody2D rigidBody;
    public GameObject shurikenPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, timeBeforeDestroy);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Throw(bool facingRight, float lookDir)
    {
        Debug.Log("Shuriken thrown");
        rigidBody.AddForce(transform.right * velocity, ForceMode2D.Impulse);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        weaponsManager.player.transform.position = collision.transform.position;
        Destroy(gameObject);
    }

    public virtual void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Debug.Log("Enemy hit");
    }
}
