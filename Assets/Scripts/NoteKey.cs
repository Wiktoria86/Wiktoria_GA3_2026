using UnityEngine;

public class NoteKey : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject keyimage;
    public GameObject keyistrue;
    public GameObject InteractE;
    public bool isplayer;
    void Start()
    {
        isplayer = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isplayer=true;
            InteractE.SetActive(true);

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = false;
            InteractE.SetActive(false);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if(isplayer)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                keyimage.SetActive(true);
                keyistrue.SetActive(true);
                InteractE.SetActive(false);
                Destroy(gameObject);

            }

        }

    }

}
