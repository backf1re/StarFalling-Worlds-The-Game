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
    public int baseHPrecoverSpeed { get; set; } // Base Hit Points recovery speed
    public int restHPrecoverSpeed { get; set; } // Hit Points recovery speed during rest
    public int sleepHPrecoverSpeed { get; set; } // Hit Points recovery speed during sleep
    public int baseAPrecoverSpeed { get; set; } // Base Action Points recovery speed
    public int restAPrecoverSpeed { get; set; } // Action Points recovery speed during rest
    public int sleepAPrecoverSpeed { get; set; } // Action Points recovery speed during sleep
    public float updateDelta;


    // Recovery by time
    void Recover()
    {
        if (currentHP < maximumHP)
        {
            updateDelta += Time.deltaTime;
            if (updateDelta >= 1f)
            {
                updateDelta = 0;
                currentHP = currentHP + baseHPrecoverSpeed + restHPrecoverSpeed + sleepHPrecoverSpeed;
            }
            //Debug.Log(currentHP.ToString() + " HP");
        }
        if (currentAP < maximumAP)
        {
            updateDelta += Time.deltaTime;
            if (updateDelta >= 1f)
            {
                updateDelta = 0;
                currentAP = currentAP + baseAPrecoverSpeed + restHPrecoverSpeed + sleepHPrecoverSpeed;
            }
            Debug.Log(currentHP.ToString() + " HP" + currentAP.ToString() + " AP");
        }
    }

        // Start is called before the first frame update
        void Start()
        {
            updateDelta = 0;
            currentHP = 1;
            maximumHP = 10;
            currentAP = 1;
            maximumAP = 10;
            currentQP = 0;
            currentEP = 0;
            Level = 1;
            Rebirth = 0;
            baseHPrecoverSpeed = 1;
            restHPrecoverSpeed = 0;
            sleepHPrecoverSpeed = 0;
            baseAPrecoverSpeed = 1;
            restAPrecoverSpeed = 0;
            sleepAPrecoverSpeed = 0;
        }

        // Update is called once per frame
        void Update()
        {
            Recover();
        }
}