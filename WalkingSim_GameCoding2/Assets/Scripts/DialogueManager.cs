using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI displayName;
    public TextMeshProUGUI placeholderOpeningLine;

    void OnEnable()
    {
        Player.OnDialogueRequested += StartDialogue;
    }

    void OnDisable()
    {
        Player.OnDialogueRequested -= StartDialogue;
    }
    void StartDialogue(NPCData npcData)
    {
        if (npcData == null)
        {
            Debug.Log("NPC Data is null");
            return;
        }
        
        if (dialoguePanel != null) dialoguePanel.SetActive(true);
        if(displayName != null) displayName.text = npcData.displayName;
        if(placeholderOpeningLine != null) placeholderOpeningLine.text = npcData.placeHolderOpeningLine;
        Debug.Log($"Dialogue start with{npcData.displayName}: {npcData.placeHolderOpeningLine}");
    }
}
