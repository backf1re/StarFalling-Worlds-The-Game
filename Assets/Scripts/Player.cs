using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Main characteristics
    public int currentHP { get; set; } // Current Hit Points
    public int maximumHP { get; set; } // Maximum Hit Points
    public int currentAP { get; set; } // Current Action Points
    public int maximumAP { get; set; } // Maximum Action Points
    public int currentQP { get; set; } // Current Quest Points
    public int currentEP { get; set; } // Current Experience Points
    // public int Gold { get; set; } // ingame money will be used from blockchain
    public int Level { get; set; } // Current Level
    public int Rebirth { get; set; } // Current Rebirth



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
