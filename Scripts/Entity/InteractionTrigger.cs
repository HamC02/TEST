using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    public GameObject interactionPopup;
    public GameObject miniGameUI;


    public string[] npcDialogues;
    private bool isPlayerInRange = false;

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            miniGameUI.SetActive(true);    
        }
    }

    private void ShowRandomDialogue()
    {
        if (npcDialogues.Length > 0)
        {
            int index = Random.Range(0, npcDialogues.Length);
            string selectedDialogue = npcDialogues[index];
            Debug.Log("NPC: " + selectedDialogue); // 실제 게임에서는 UI로 출력
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(false);
        }
    }
}