﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right);
        }
    }
}
