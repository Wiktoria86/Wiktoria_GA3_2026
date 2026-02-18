using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject respawnPoint;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
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
