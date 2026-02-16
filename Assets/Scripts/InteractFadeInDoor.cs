using System.Collections;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractFadeInDoor : MonoBehaviour
{

    // Update is called once per frame
    public GameObject NoteTextHallway1;
    public GameObject keyistrue;
    public GameObject InteractE;
    public Image blackScreen;
    public float fadeDuration = 2f;
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

    void Update()
    {
        if (isplayer)

        if (Input.GetKeyDown(KeyCode.E))
        {
                NoteTextHallway1.SetActive(true);
                keyistrue.SetActive(true);
                StartCoroutine(FadeToBlack());
        }

    }

    IEnumerator FadeToBlack()
    {

        float elapsedTime = 0f;
        Color color = blackScreen.color;

        while (elapsedTime < fadeDuration) 
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Lerp(0f, 1f, elapsedTime);
            blackScreen.color = color;
            yield return null;

        }

        color.a = 1f;
        blackScreen.color = color;


        SceneManager.LoadScene(1);
    }
    
}