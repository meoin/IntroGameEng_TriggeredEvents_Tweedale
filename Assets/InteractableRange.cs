using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class InteractableRange : MonoBehaviour
{
    public Outline outline;
    public PlayableDirector timeline;
    public string tagToTrigger = "Player";

    public bool oneTimeUse = true;
    private bool used = false;
    private bool interactable = false;

    private GameObject interactPrompt;

    private void Start()
    {
        interactPrompt = GameObject.Find("InteractUI").transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactable) 
        {
            if (!used || !oneTimeUse) 
            {
                used = true;
                timeline.Play();

                if (oneTimeUse) 
                {
                    interactable = false;
                    outline.enabled = false;
                    interactPrompt.SetActive(false);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something has entered the trigger");
        if (other.tag == tagToTrigger)
        {
            Debug.Log("Player is in the trigger zone");
            if (!used || !oneTimeUse) 
            {
                interactable = true;
                outline.enabled = true;
                interactPrompt.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Something has exited the trigger");
        if (other.tag == tagToTrigger)
        {
            Debug.Log("Player has left the trigger zone");
            interactable = false;
            outline.enabled = false;
            interactPrompt.SetActive(false);
        }
    }
}
