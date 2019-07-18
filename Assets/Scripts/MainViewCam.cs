using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainViewCam : MonoBehaviour
{
    
    public Transform mwcTarget;
   int distance = -10;
   float lift = 0;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, lift, distance) + mwcTarget.position;
        transform.LookAt(mwcTarget);
        

    }
}
