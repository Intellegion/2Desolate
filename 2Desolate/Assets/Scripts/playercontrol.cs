using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    Vector2 jump;
    float move;
    Transform pos;
    public GameObject mask;
    Transform mt;
    bool isTouch;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mt = mask.GetComponent<Transform>();
        jump = new Vector2(0.0f, 500.0f);
        pos = GetComponent<Transform>();    
    }
    // Update is called once per frame
    void FixedUpdate()
    { 
        move = Input.GetAxis("Horizontal")*0.3f;
        if((Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))&&isTouch)
            rb.AddForce(jump);
        transform.Translate(move, 0.0f, 0.0f,Space.World);
        mt.position = new Vector3(transform.position.x, transform.position.y, 0.0f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isTouch = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        isTouch = false;
    }
}
