using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomInstruction : MonoBehaviour {
    public Text text;
    public GameObject thisObject;
    public KeyFunctions kyf;
    public int ReloadTime = 5;
    public string[] InstructionArray;
    float xTimer = 0.0f;


	// Update is called once per frame
	void Update () {

        if (kyf.Easy == true)
        {
            ReloadTime = 5;
        }
        else if (kyf.Medium == true)
        {
            ReloadTime = 4;
        }
        else if (kyf.Excruciatinglyhard == true)
        {
            ReloadTime = 3;
        }
        else if (kyf.UFB == true)
        {
            ReloadTime = 2;
        }

        if (thisObject == null)
        {
            thisObject = GameObject.FindGameObjectWithTag("ThisOneIsTurnedOn");
        }

        if(kyf == null)
        {
            kyf = thisObject.GetComponent<KeyFunctions>();
        }

        if (xTimer > ReloadTime || text.text == "")
        {
            text.text = InstructionArray[Random.Range(0, InstructionArray.Length - 1)];
            xTimer = 0;
            if(kyf.PressedButton == true)
            {
                kyf.PressedButton = false;
            }
            else
            {
                if (kyf.Easy == true)
                {
                    kyf.SHealth -= 1;
                    kyf.ShipHealth.text = kyf.SHealth.ToString();
                    kyf.PressedButton = false;
                }else if(kyf.Medium == true)
                {
                    kyf.SHealth -= 3;
                    kyf.ShipHealth.text = kyf.SHealth.ToString();
                    kyf.PressedButton = false;
                } else if(kyf.Excruciatinglyhard == true)
                {
                    kyf.SHealth -= 6;
                    kyf.ShipHealth.text = kyf.SHealth.ToString();
                    kyf.PressedButton = false;
                }
            }
        }
        else
        {
            xTimer += Time.deltaTime;
        }
	}
}
