using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_0_map : MonoBehaviour
{
    //Obstacle on map World_0_Map item 000
    public Transform obstacle01;
    public int obstacle01Count;
   
    private Vector2 mapSize = new Vector2 (50, 50);

    // Start is called before the first frame update
    void Start()
    {
        generateMap();
    }
    void generateMap()
    {
        for (int i = 0; i < obstacle01Count; i++)
        {
            Instantiate(obstacle01, new Vector2(Random.Range(0, mapSize.x),
                                                  Random.Range(0, mapSize.y)), obstacle01.rotation);
        }


    }
    // Update is called once per frame
    void Update()
    {

    }
}