using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Projectile : MonoBehaviour
{
    public GameObject prefabProjectile;
    public GameObject projectile;
    public Vector3 launchPos;
    private float movementX;
    private float movementY;
    public float velocityMult = 8f;
    public bool aimingMode;

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void OnMouseDown()
    {
        aimingMode = true;
        projectile = Instantiate(prefabProjectile) as GameObject;
        projectile.transform.position = launchPos;
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }

    void OnTriggerEnter(Collider other)
    {
        // when the trigger is hit by something
        // check to see if it's a Projectile 
        if (other.gameObject.tag == "Target" || other.gameObject.tag == "Target_1" || other.gameObject.tag == "Target_2" || other.gameObject.tag == "Target_3" || other.gameObject.tag == "Target_4")
        {

        }
        {
            // if so, set goalMet = true
            Goal.goalMet = true;

            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, 100))
                    print("Hit something!");
            }
        }
    }
}