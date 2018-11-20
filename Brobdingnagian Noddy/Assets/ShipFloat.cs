using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFloat : MonoBehaviour {
    float ShipOriginY;
    float ShipMaxY;
    bool ResetOpposite;

    void Start()
    {
        ShipOriginY = transform.position.y;
        ShipMaxY = transform.position.y + 3;
    }


	
	// Update is called once per frame
	void Update () {
        if (ResetOpposite == true)
        {
            if (transform.position.y < ShipMaxY)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            } else
            {
                ResetOpposite = false;
            }
        }
        else
        {
            if (transform.position.y > ShipOriginY)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
            }
            else
            {
                ResetOpposite = true;
            }
        }

    }
}
