using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStory : MonoBehaviour {
    public GameObject MyStorys;
    public GameObject TitleScreen;
    public GameObject MyStoryMusic;
    public GameObject TitleScreenMusic;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyStorys.SetActive(false);
            MyStoryMusic.SetActive(false);
            TitleScreen.SetActive(true);
            TitleScreenMusic.SetActive(true);
        }
    }
}
