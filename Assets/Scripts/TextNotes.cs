using UnityEngine;

public class TextNotes : MonoBehaviour
{
    
    public GameObject NoteRoom1;
    public bool isplayer;
    void Start()
    {
        isplayer = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = true;
            NoteRoom1.SetActive(true);

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = false;
            NoteRoom1.SetActive(false);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
