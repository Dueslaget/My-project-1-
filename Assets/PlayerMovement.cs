using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody Brick;
    // Start is called before the first frame update
    void Start()
    {
        Brick = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("space"))
       {
          Brick.velocity = new Vector3(0, 5, 0);
       }
       if (Input.GetKey("w"))
       {
          Brick.velocity = new Vector3(0, 0, 5);
       }
        if (Input.GetKey("s"))
       {
          Brick.velocity = new Vector3(0, 0, -5);
       }
        if (Input.GetKey("a"))
       {
          Brick.velocity = new Vector3(-5, 0, 0);
       }
        if (Input.GetKey("d"))
       {
          Brick.velocity = new Vector3(5, 0, 0);
       }
    }
}
