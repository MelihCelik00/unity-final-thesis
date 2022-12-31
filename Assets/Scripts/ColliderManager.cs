using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{   
    public int counter;
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Agent") 
        {
            Debug.Log("Enter!");
            counter++;
        }
    }

    void OnTriggerStay(Collider other){
        Debug.Log("Stay");
    }
}
