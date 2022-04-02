using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class RotatingScript : MonoBehaviour
{
    public int i; 
    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetKey("r")|| Input.GetKey("l") || Input.GetKey("b") || Input.GetKey("f"))
        {
            i= 1;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            i = 1;
        }
        if (i==1)
        {
            int num1 = UnityEngine.Random.Range(-100, 100) + 500;
            int num2 = UnityEngine.Random.Range(-100, 100) + 500;
            int num3 = UnityEngine.Random.Range(-200, 200) + 500;
            //int num = num1 + num2 + num3 + 500;
            this.transform.Rotate(new Vector3(num1 * Time.deltaTime, num2 * Time.deltaTime, num3 * Time.deltaTime));
        }
    }
}
