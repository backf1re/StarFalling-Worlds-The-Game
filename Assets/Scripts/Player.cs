using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Main characteristics
    public int Rebirth { get; set; } // Current Rebirth
    public int Level { get; set; } // Current Level
    public int currentHP { get; set; } // Current Hit Points
    public int maximumHP { get; set; } // Maximum Hit Points
    public int currentAP { get; set; } // Current Action Points
    public int maximumAP { get; set; } // Maximum Action Points
    public int currentQP { get; set; } // Current Quest Points
    public int currentEP { get; set; } // Current Experience Points
    public int baseHPrecoverSpeed { get; set; } // Base Hit Points recovery speed
    public int restHPrecoverSpeed { get; set; } // Hit Points recovery speed during rest
    public int sleepHPrecoverSpeed { get; set; } // Hit Points recovery speed during sleep
    public int baseAPrecoverSpeed { get; set; } // Base Action Points recovery speed
    public int restAPrecoverSpeed { get; set; } // Action Points recovery speed during rest
    public int sleepAPrecoverSpeed { get; set; } // Action Points recovery speed during sleep
    public int Weight { get; set; } // Player Weight
    // Counter
    public float updateDeltaHP;
    public float updateDeltaAP;

    //Bars
    private PlayerBar playerBar;


    // Recovery by time
    void RecoverHP()
      {
          if (currentHP < maximumHP)
          {
              updateDeltaHP += Time.deltaTime;
              if (updateDeltaHP >= 1f)
              {
                  updateDeltaHP = 0;
                  currentHP = currentHP + baseHPrecoverSpeed + restHPrecoverSpeed + sleepHPrecoverSpeed;
              }
          }
      }
      void RecoverAP()
      {
          if (currentAP < maximumAP)
          {
              updateDeltaAP += Time.deltaTime;
              if (updateDeltaAP >= 1f)
              {
                  updateDeltaAP = 0;
                  currentAP = currentAP + baseAPrecoverSpeed + restHPrecoverSpeed + sleepHPrecoverSpeed;
              }
          }
      }
     
    // Start is called before the first frame update
    void Start()
        {
        playerBar.setSize(0.4f, 1);
            updateDeltaHP = 0;
            updateDeltaHP = 0;
            currentHP = 1;
            maximumHP = 100;
            currentAP = 1;
            maximumAP = 100;
            currentQP = 0;
            currentEP = 0;
            Level = 1;
            Rebirth = 0;
            Weight = 1;
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
           RecoverHP();
           RecoverAP();
        Debug.Log(currentHP.ToString() + " HP" + " / " + currentAP.ToString() + " AP");
    }
}