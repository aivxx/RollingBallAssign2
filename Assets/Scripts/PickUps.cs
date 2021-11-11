using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    //counter for the remaining collectables in the scene
    public int counter;

    //the prefab that will be instantiated
    public GameObject bonusObject;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("PickUp").Length;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pickup()
    {
        counter--;


    }

 
}
