using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutMainDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject mainDoor;
    public GameObject InteractE;
    public GameObject keyistrue;
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
    // Update is called once per frame
    void Update()
    {

        if (isplayer)
        if (Input.GetKeyDown(KeyCode.E))
        {
            mainDoor.SetActive(true);
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


        SceneManager.LoadScene(0);
    }


}
