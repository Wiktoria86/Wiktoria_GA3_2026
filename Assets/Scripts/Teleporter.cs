using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public GameObject Player;
    public GameObject TeleportTo;

    private void OnTriggerEnter(Collider collison)
    {
        if (collison.gameObject.CompareTag("Teleporter"))
        {
            Player.transform.position = TeleportTo.transform.position;
        }
    }

    
    void Update()
    {
        
    }
}
