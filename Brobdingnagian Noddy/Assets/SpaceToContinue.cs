﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceToContinue : MonoBehaviour {
    public GameObject Dark;
    public GameObject Light;
    public GameObject MainGame;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dark.SetActive(false);
            Light.SetActive(false);
            MainGame.SetActive(true);
        }
	}
}
