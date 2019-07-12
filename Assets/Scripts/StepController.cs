using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour
{
    public Transform character01_0;
    public float xStep = 0.5f;
    public float yStep = 0.3f;
    public float transH = 0f;
    public float transV = 0f;

    //Making one move after one key pressed
    void Update()
    {
        //Making one move after one key pressed
        
        if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0 )
        {
          float transV = 0;
          float transH = xStep;
          transform.Translate(new Vector3(transH, transV, 0));
        }
        if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0)
        {
            float transV = 0;
            float transH = -xStep;
            transform.Translate(new Vector3(transH, transV, 0));
        }
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0)
        {
            float transV = -yStep;
            float transH = 0;
            transform.Translate(new Vector3(transH, transV, 0));
        }
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
        {
            float transV = yStep;
            float transH = 0;
            transform.Translate(new Vector3(transH, transV, 0));
        }

        
    }
}
