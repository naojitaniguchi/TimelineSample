using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallUp : MonoBehaviour
{
    public GameObject sphereObject;
    public GameObject redLightObject;
    public GameObject fukidasiObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("OnTriggerEnter called");
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");

        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "Cube")
        {
            Debug.Log("Cube 来た！");

            sphereObject.GetComponent<Player>().callUpAnim();
            redLightObject.SetActive(true);
            fukidasiObject.SetActive(true);
        }
    }

}
