using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject InteractE;
    public GameObject keyistrue;
    public bool isplayer;
    Animator animator;
    void Start()
    {
        isplayer = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = true;
            InteractE.SetActive(true);
            animator = GetComponent<Animator>();

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
        if (keyistrue.active)
        {
            if(isplayer)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InteractE.SetActive(false);
                    animator.enabled = true;

                }



            }
        }
    }


}
