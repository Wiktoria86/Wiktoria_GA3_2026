using FMODUnity;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{

    public EventReference footstepEvent;
    public float stepInterval = 0.1f;  

    private float timer;
    private bool wasMoving = false;

    void Update()
    {
        bool isMoving = Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0;

        if (isMoving)
        {
            timer += Time.deltaTime;
            if (timer >= stepInterval)
            {
                RuntimeManager.PlayOneShot(footstepEvent, transform.position);
                timer = 0;
            }
        }
        else
        {
            timer = 0;  
        }

        wasMoving = isMoving;
    }
}
