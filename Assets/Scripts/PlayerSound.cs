using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public EventReference footstepEvent; 
    public float minStepInterval = 0.3f;
    private float lastStepTime;

    void OnCollisionEnter(Collision collision)
    {
        if (Time.time - lastStepTime < minStepInterval) return;

        string surface = GetSurfaceType(collision.gameObject);
        EventInstance instance = RuntimeManager.CreateInstance(footstepEvent);

       
        switch (surface)
        {
            case "Tile":
                instance.setParameterByName("SurfaceType", 0);
                break;
            case "Carpet":
                instance.setParameterByName("SurfaceType", 1);
                break;
            case "Wood":
                instance.setParameterByName("SurfaceType", 2);
                break;
            default:
                instance.setParameterByName("SurfaceType", 0);
                break;
        }

        instance.start();
        lastStepTime = Time.time;
    }

    string GetSurfaceType(GameObject obj)
    {
        if (obj.CompareTag("Tile")) return "Tile";
        if (obj.CompareTag("Carpet")) return "Carpet";
        if (obj.CompareTag("Wood")) return "Wood";
        return "Tile"; 
    }
}
