using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StepController : MonoBehaviour
{
    public Transform character01_0;
    public int currentAP;
    public int Weight;
    private Player player;
    public float xStep = 0.5f;
    public float yStep = 0.3f;
    public float transH = 0f;
    public float transV = 0f;

    void Start()
    {
        player = gameObject.GetComponent<Player>();
        currentAP = player.currentAP;
        Weight = player.Weight;
    }

        //Making one move after one key pressed
        void Update()
    {
        //Making one move after one key pressed if AP > 1
        if (player.currentAP > 1)
        {

            if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
            {
                float transV = 0;
                float transH = xStep;
                player.currentAP = player.currentAP - player.Weight;
                transform.Translate(new Vector3(transH, transV, 0));
            }
            if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0)
            {
                float transV = 0;
                float transH = -xStep;
                player.currentAP = player.currentAP - player.Weight;
                transform.Translate(new Vector3(transH, transV, 0));
            }
            if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0)
            {
                float transV = -yStep;
                float transH = 0;
                player.currentAP = player.currentAP - player.Weight;
                transform.Translate(new Vector3(transH, transV, 0));
            }
            if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
            {
                float transV = yStep;
                float transH = 0;
                player.currentAP = player.currentAP - player.Weight;
                transform.Translate(new Vector3(transH, transV, 0));
            }
        }
     }
}
