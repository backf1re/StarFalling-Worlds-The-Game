using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycoltroller : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    
    // Update is called once per frame
    void Update()
    {
        float transV = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float transH = Input.GetAxis("Horizontal") * playerSpeed * Time.fixedDeltaTime;

        transform.Translate(new Vector3(transH, transV, 0));
    }
}
