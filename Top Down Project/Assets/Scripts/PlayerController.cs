using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    //Variables
    public float Speed = 5;

    public Rigidbody2D rb;

    Vector2 movement; //
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Trigger/Getting input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() 
    {     
        //Movement  
         rb.MovePosition(rb.position + movement * Speed * Time.deltaTime);
    }
}
