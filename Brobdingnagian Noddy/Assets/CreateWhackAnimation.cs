using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWhackAnimation : MonoBehaviour {
    public GameObject ReadyToWhack;
    public GameObject WhackThatButton;
    private bool DoTheWhack = false;
    int X = 0;

	// Update is called once per frame
	void Update () {
        if (X == 15)
        {
            if (DoTheWhack == false)
            {
                ReadyToWhack.SetActive(false);
                WhackThatButton.SetActive(true);
                DoTheWhack = true;
            }
            else
            {
                ReadyToWhack.SetActive(true);
                WhackThatButton.SetActive(false);
                DoTheWhack = false;
            }
            X = 0;
        }
        else
        {
            X++;
        }
		
	}
}
