using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public string tagToTrigger = "Player";

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something has entered the trigger");
        if (other.tag == tagToTrigger) //The colliding object isn't our object
        {
            Debug.Log("Player is in the trigger zone");
            timeline.Play();
        }
    }
}
