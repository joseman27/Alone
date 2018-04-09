﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControldelJugador : MonoBehaviour {
    public float speed;


    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(-35, 0,0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(35,0,0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
