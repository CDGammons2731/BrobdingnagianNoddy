using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTaunt : MonoBehaviour {
    public string[] SmellyCat;
    public float ReloadTime = 5;
    public Text text;
    float xTimer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (xTimer > ReloadTime || text.text == "")
        {
            text.text = SmellyCat[Random.Range(0, SmellyCat.Length - 1)];
            xTimer = 0;
        }
        else
        {
            xTimer += Time.deltaTime;
        }
    }
}
