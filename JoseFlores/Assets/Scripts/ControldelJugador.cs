using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControldelJugador : MonoBehaviour {
    public float speed;
    Vector3 InicialPosition;
    Rigidbody playerRb;



    // Use this for initialization
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        InicialPosition = transform.position; 
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(new Vector3(-35, 0,0) * Time.deltaTime);
            playerRb.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
           
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(new Vector3(35,0,0) * Time.deltaTime);
            playerRb.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            playerRb.MovePosition(transform.position + (Vector3.forward * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.back * speed * Time.deltaTime);
            playerRb.MovePosition(transform.position + (Vector3.back * speed * Time.deltaTime));
        }
    }
   public void ResetPosition() {
        transform.position = InicialPosition;
    
    }
}
