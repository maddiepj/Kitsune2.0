using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{

    public WeaponsManager weaponMgr;
    public GameObject player;
    public Weapon projectile;

    // Start is called before the first frame update
    void Start()
    {
        weaponMgr = GetComponent<WeaponsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile = weaponMgr.projectile;
    }

     void Throw()
     {
        //public float velocity = projectile.velocity;
     }

}
