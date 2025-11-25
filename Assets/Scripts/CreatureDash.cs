using System;
using TMPro;
using UnityEngine;

public class CreatureDash : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 endPosition;
    public AudioSource audioSource;
    public float travelDistance;
    public float speed;
    public bool move = false;
    private bool playedSound = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + (transform.forward * travelDistance);
    }

    // Update is called once per frame
    void Update()
    {
        if (move) 
        {
            if (!playedSound)
            {
                audioSource.Play();
                playedSound = true;
            }

            Debug.Log("Creature is moving");
            if (Vector3.Distance(transform.position, endPosition) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
            }
            else
            {
                transform.position = endPosition;
                move = false;
            }
        }
    }
}
