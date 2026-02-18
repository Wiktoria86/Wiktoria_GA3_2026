using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInBackrooms : MonoBehaviour
{
    public Image fadeImage; 
    public float fadeDuration = 5f; 
    private bool isFading = false;
    private float elapsedTime = 0f;

    private void OnTriggerEnter(Collider collision)
    {
        if (!isFading)
        {
            isFading = true;
            elapsedTime = 0f;
        }
    }

    private void Update()
    {
        if (isFading)
        {
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / fadeDuration);

            
            float alpha = Mathf.SmoothStep(0f, 1f, normalizedTime);

            Color color = fadeImage.color;
            color.a = alpha;
            fadeImage.color = color;

            if (elapsedTime >= fadeDuration)
            {
                isFading = false;
                
                fadeImage.color = new Color(color.r, color.g, color.b, 1f);
                SceneManager.LoadScene(0);
            }
        }
    }

}