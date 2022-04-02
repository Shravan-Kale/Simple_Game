using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r") || Input.GetKey("l") || Input.GetKey("b") || Input.GetKey("f"))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
