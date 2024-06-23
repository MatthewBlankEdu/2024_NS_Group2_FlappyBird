using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{ 
    public Vector2 JumpForce;
    public Rigidbody2D Rb2D;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        Rb2D.velocity = Vector2.zero;
        Rb2D.AddForce(JumpForce, ForceMode2D.Impulse);
    }
}
