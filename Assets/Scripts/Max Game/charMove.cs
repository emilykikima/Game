﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : movement {


	// Use this for initialization
	void Start () {
        SetUp();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveLeft();
			man.StartCoroutine("MoveOrder");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveRight();
			man.StartCoroutine("MoveOrder");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
			moveUp();
			man.StartCoroutine("MoveOrder");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            moveDown();
			man.StartCoroutine("MoveOrder");
        }



    }


}
