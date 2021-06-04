using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float velocity { get; set; }
    public string weaponName { get; set; }
    public AudioClip throwSound { get; set; }
    public float coolDownLength { get; set; }
    public int damage { get; set; }
    public Transform throwPoint;
    //public GameObject projectilePrefab;
    public WeaponsManager weaponsManager;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        //weaponsManager = GameObject.FindGameObjectWithTag("WeaponManager").GetComponent<WeaponsManager>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

   public virtual void Throw(bool facingRight, float dir)
    {
        Debug.Log("Weapon thrown");
    }

    public virtual void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Debug.Log("Enemy hit");
    }

}
