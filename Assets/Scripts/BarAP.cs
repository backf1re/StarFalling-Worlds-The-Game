using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarAP : MonoBehaviour
{
    private Transform barAP;
    private Player player;
    public float scaleAP;

    // Start is called before the first frame update
    void Start()
    {
        barAP = transform.Find("BarAP");
    }
    //Moving bar fill according current HP AP
    void Update()
    {
        //scaleHP = currentHP / maximumHP;
        scaleAP = Player.scaleAP;
        barAP.localScale = new Vector3(scaleAP, 1f);
    }
}
