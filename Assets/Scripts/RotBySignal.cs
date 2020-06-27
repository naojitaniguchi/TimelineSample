using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotBySignal : MonoBehaviour
{
    public float rotSpeed = 10.0f ;
    bool rotateFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateFlag)
        {
            gameObject.transform.Rotate(new Vector3(rotSpeed * Time.deltaTime, 0.0f, 0.0f));
        }
    }

    public void GetSignal()
    {
        Debug.Log("Get signal!");
        rotateFlag = true;
    }
}
