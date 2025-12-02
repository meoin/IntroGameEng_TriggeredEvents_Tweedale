using UnityEngine;
using UnityEngine.UI;

public class CreatureStatic : MonoBehaviour
{
    public Transform player;
    public Image staticEffect;
    private float opacity;
    public float distanceToTrigger = 3;
    public float maxOpacity = 0.7f;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < distanceToTrigger)
        {
            opacity = Mathf.Min(Mathf.Max(1 - (distance / distanceToTrigger), 0), maxOpacity);
            Debug.Log(opacity);
        }
        else 
        {
            opacity = 0;
        }

        staticEffect.color = new Color(1, 1, 1, opacity);
    }
}
