using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarHP : MonoBehaviour
{
    private Transform barHP;
    private Player player;
    public float scaleHP;

    // Start is called before the first frame update
    void Start()
    {
        barHP = transform.Find("BarHP");
    }
    //Moving bar fill according current HP AP
    void Update ()
    {
        //scaleHP = currentHP / maximumHP;
        scaleHP = Player.scaleHP;
        barHP.localScale = new Vector3(scaleHP, 1f);
    }
}
