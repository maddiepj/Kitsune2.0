using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Weapon : MonoBehaviour
{

    public float velocity { get; set; }
    public string weaponName { get;  set; }
    public AudioClip throwSound { get; set; }
    public float coolDownLength { get; set; }
    public int damage { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Behavior();

}
