using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public CharacterController player;
  

    private void OnTriggerEnter(Collider other)
    {
        // Collect pick ups
        if (other.CompareTag("PickUp"))
        {
            Debug.Log("Pick up collected!");
            GameObject.Destroy(other.gameObject);
        }
    }
}
