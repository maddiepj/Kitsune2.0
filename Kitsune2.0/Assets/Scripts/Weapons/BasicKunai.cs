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

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public override void Throw(bool facingRight, float lookDir)
    {
        if (facingRight)
        {
            rigidBody.AddForce(transform.right * velocity, ForceMode2D.Impulse);
        }
        else
        {
            rigidBody.AddForce(-transform.right * velocity, ForceMode2D.Impulse);
        }
    }

    public override void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Enemy hit" + hitInfo.name);
        Destroy(gameObject);
    }

}
