using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    //Variables
    public float Speed = 5;

    public Rigidbody2D rb;
    public Camera cam; //refernece to cam

    Vector2 movement; 
    Vector2 mousePos; //Store Mouse Position
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Trigger/Getting input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate() 
    {     
        //Movement  
         rb.MovePosition(rb.position + movement.normalized * Speed * Time.deltaTime);
         
         //Rotate Player to mouse position
         Vector2 lookPos = mousePos - rb.position;
         float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg - 90f;
         rb.rotation = angle;
    }
}
