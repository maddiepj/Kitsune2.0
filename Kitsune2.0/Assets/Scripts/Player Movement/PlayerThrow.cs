using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    public WeaponsManager weaponMgr;
    public GameObject weapon;
    public Transform throwPoint;
    public Camera camera;
    public PlayerAim playerAim;
    public GameObject currentProjectile;

    public Rigidbody2D rigidBody;
    LineRenderer line;
    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        playerAim = gameObject.GetComponent<PlayerAim>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && playerAim.canShoot)
        {
            Quaternion rot = playerAim.getRotation();
            Weapon projectile = Instantiate(weaponMgr.getProjectile(), throwPoint.position, rot);
            projectile.Throw(playerAim.facingRight, playerAim.getAngle());

        }
    }

}
