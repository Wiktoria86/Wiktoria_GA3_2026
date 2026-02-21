using UnityEngine;
using System.Collections; 
using System.Collections.Generic;
using TMPro;

public class NPCInteractable : MonoBehaviour
{
    [SerializeField]
    private string interactText;

    [SerializeField]
    private TextMeshProUGUI dialogueText; 

    [SerializeField]
    private GameObject dialoguePanel; 


    public void Interact()
    {
        Debug.Log("Interact!");
        ShowDialogue();

    }

    private void ShowDialogue()
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(true);

        if (dialogueText != null)
        {
            dialogueText.text = interactText;
            dialogueText.gameObject.SetActive(true);
        }
   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (dialoguePanel != null)
                dialoguePanel.SetActive(false);

            if (dialogueText != null)
            {
                dialogueText.text = interactText;
                dialogueText.gameObject.SetActive(false);
            }

        }

    }

    public void HideDialogue()
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);

    }


    public string GetInteractText()
    {
        return interactText; 
    }


}
