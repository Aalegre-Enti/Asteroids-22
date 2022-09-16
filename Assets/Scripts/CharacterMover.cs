using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float movement_speed = 1;
    public float movement_rotation = 1;
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        if (vertical > 0)
        {
            //transform.position = transform.position + transform.up * vertical * movement_speed * Time.deltaTime;
            rb.AddForce(transform.up * vertical * movement_speed * Time.deltaTime);
            anim.SetBool("Movimiento", true);
        }
        else
        {
            anim.SetBool("Movimiento", false);
        }
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -horizontal * movement_rotation * Time.deltaTime);
    }
}