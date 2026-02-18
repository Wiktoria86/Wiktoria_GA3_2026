using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    
    public GameObject respawnPoint;
    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;

        }
    }


}
