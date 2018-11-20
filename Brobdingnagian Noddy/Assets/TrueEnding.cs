using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrueEnding : MonoBehaviour {
    public GameObject TitleScreen;
    public GameObject TitleScreenMusic;
    public GameObject tending;
    public GameObject temusic;
    public GameObject[] TrueEndingParts;
    int i = 0;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i < TrueEndingParts.Length - 1)
            {
                if (i + 1 != TrueEndingParts.Length)
                {
                    TrueEndingParts[i].SetActive(false);
                    TrueEndingParts[i + 1].SetActive(true);
                }
                i++;
            }
            else
            {
                TrueEndingParts[0].SetActive(true);
                if (temusic != null)
                {
                    temusic.SetActive(false);
                }
                tending.SetActive(false);
                TitleScreen.SetActive(true);
                TitleScreenMusic.SetActive(true);
            }
        }
		
	}
}
