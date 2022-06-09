using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speedboost;
    [SerializeField] float basespeed;
    Rigidbody2D rb2d;
    [SerializeField] float Torque=15f;
    SurfaceEffector2D surfacecollider;
    bool move = true;
    // Start is called before the first frame update
    void Start()
    {
        surfacecollider = FindObjectOfType<SurfaceEffector2D>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (move==true)
        {
            Rotateplayer();
            Speedup(); 
        }
    }

    void Speedup()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfacecollider.speed = speedboost;
        }
        else  
        {
            surfacecollider.speed = basespeed;
        }
    }
    public void Disablecontrols()
    {
        move = false;
    }

    void Rotateplayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(Torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-Torque);
        }
    }
}
