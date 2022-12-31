using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    private float evacuationTime;
    private bool inBuilding;
    private int totalSurvivorsLeft;
    private GameObject[] tempGO;
    private bool isFirstSurvivorIn;

    void Start()
    {
        tempGO = GameObject.FindGameObjectsWithTag("Agent");
        totalSurvivorsLeft = tempGO.Length;
        Debug.Log(totalSurvivorsLeft);
    }

    void Update()
    {
        if(inBuilding)
        {
            evacuationTime += Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("zort");
        if (col.gameObject.tag == "Agent")
        {
            if (!isFirstSurvivorIn)
            {
                inBuilding = true;
                isFirstSurvivorIn = true;
            }
            
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Agent")
        {
            totalSurvivorsLeft--;
            if (totalSurvivorsLeft == 0)
            {
                inBuilding = false;
                Debug.Log(evacuationTime);
            }
        }
    }
}
