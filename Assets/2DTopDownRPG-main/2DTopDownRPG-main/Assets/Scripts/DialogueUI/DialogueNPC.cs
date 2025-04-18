using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueNPC : Interactable
{
    //Reference to the intermediate dialogue value
    [SerializeField] private TextAssetValue dialogueValue;
    //Reference to the NPC's dialogue
    [SerializeField] private TextAsset myDialogue;
    //Notification to send to the canvases to activate and check dialogue
    [SerializeField] private Notification branchingDialogueNotification;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInRange)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                dialogueValue.value = myDialogue;
                branchingDialogueNotification.Raise();
            }
        }
    }
}
