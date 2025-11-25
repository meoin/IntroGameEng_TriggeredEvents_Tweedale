using System;
using UnityEngine;

public class CreatureTrigger : MonoBehaviour
{
    public GameObject creature;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something has entered the trigger");
        if (other.tag == "Player") //The colliding object isn't our object
        {
            Debug.Log("Player is in the trigger zone");
            creature.GetComponent<CreatureDash>().move = true;
        }
    }

}
