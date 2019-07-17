using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBar : MonoBehaviour
{
    //public Transform BarHP;
    // private Transform bar;
    public int currentAP;
    public int currentHP;
    public int maximumAP;
    public int maximumHP;
    private Player player;
    private float scaleHP;

    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("BarHP");
        player = gameObject.GetComponent<Player>();
        currentAP = player.currentAP;
        currentHP = player.currentHP;
        maximumAP = player.maximumAP;
        maximumHP = player.maximumHP;
    }
    //Moving bar fill according current HP AP
    public void SetSize(float sizeNormalized)
    {
    // scaleHP = 10f / 100f;
     bar.localScale = new Vector3(sizeNormalized, 1f);
    }
}
