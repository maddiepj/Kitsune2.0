using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public LineRenderer line;
    public Vector2 mousePos;
    public float angle;
    public Quaternion rotation;
    public Camera camera;
    public PlayerMovement playerMovement;
    public bool facingRight;
    public bool canShoot = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        playerMovement = gameObject.GetComponent<PlayerMovement>(); 
        facingRight = playerMovement.facingRight;
    }

    // Update is called once per frame
    void Update()
    {
        facingRight = playerMovement.facingRight;
        mousePos = camera.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);

        line = gameObject.GetComponent<LineRenderer>();
        line.SetWidth(0.05f, 0.05f);

        Vector2 lookDirection = mousePos - rigidBody.position;
        angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        // Check if facing right and mouse is to the right of the player
        if (facingRight && mousePos.x > gameObject.transform.position.x && (angle < 125 && angle > -125))
        {
            line.enabled = true;
            canShoot = true;

            lookDirection = Vector3.ClampMagnitude(lookDirection, 1);

            rotation = Quaternion.Euler(0f, 0f, angle);

            Vector2 test = new Vector2(mousePos.x, mousePos.y);

            line.SetPosition(0, test);
            line.SetPosition(1, transform.position);
        }


        // Check if facing left and mouse is to the left of the player
        else if (!facingRight && mousePos.x < gameObject.transform.position.x && ((angle > 125 && angle <= 180) || (angle < -90 && angle > -180)))
        {
            line.enabled = true;
            canShoot = true;

            lookDirection = Vector3.ClampMagnitude(lookDirection, 1);

            rotation = Quaternion.Euler(0f, 0f, angle);

            Vector2 test = new Vector2(mousePos.x, mousePos.y);

            line.SetPosition(0, test);
            line.SetPosition(1, transform.position);
        }

        // Otherwise player is unable to shoot (e.g. you can't shoot in a direction you're not facing)
        else
        {
            line.enabled = false;
            canShoot = false;
        }
    }


    public float getAngle()
    {
        return angle;
    }

    public Quaternion getRotation()
    {
        return rotation;
    }

}
