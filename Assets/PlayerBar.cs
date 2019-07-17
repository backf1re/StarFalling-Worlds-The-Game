using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBar : MonoBehaviour
{
   // private Transform BarHP;
    public int currentAP;
    public int currentHP;
    public int maximumAP;
    public int maximumHP;
    private Player player;
    private float HP;
    // Start is called before the first frame update
    void Start()
    {
      //  BarHP = transform.Find("BarHP");
        player = gameObject.GetComponent<Player>();
        currentAP = player.currentAP;
        currentHP = player.currentHP;
        maximumAP = player.maximumAP;
        maximumHP = player.maximumHP;
        Transform BarHP = transform.Find("BarHP");
        BarHP.localScale = new Vector3(0.4f, 1f);
    }
    /*/
    public void setsize(float sizeNormalized)
    {
        barHP.localScale = new Vector3(sizeNormalized, 1f);
    }
    /*/
    //Moving bar fill according current HP AP
    void Update()
    {
        //HP = currentHP / maximumHP;
        //BarHP.localScale = new Vector3(HP, 1f);
    }
}
