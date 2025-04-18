using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;


public class BranchingDialogueController : MonoBehaviour
{
    [SerializeField] private GameObject branchingCanvas;
    [SerializeField] private GameObject dialoguePrefab;
    [SerializeField] private GameObject choicePrefab;
    [SerializeField] private TextAssetValue dialogueValue;
    [SerializeField] private Story myStory;
    [SerializeField] private GameObject dialogueHolder;
    [SerializeField] private GameObject choiceHolder;
    [SerializeField] private ScrollRect dialogueScroll;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableCanvas()
    {
        branchingCanvas.SetActive(true);
        SetStory();
        RefreshView();
    }

    public void SetStory()
    {
        if(dialogueValue.value)
        {
            DeleteOldDialogs();
            myStory = new Story(dialogueValue.value.text);
        }
        else
        {
            Debug.Log("Something went wrong with the story setup");
        }
    }

    void DeleteOldDialogs()
    {
        for (int i = 0; i < dialogueHolder.transform.childCount; i++)
        {
            Destroy(dialogueHolder.transform.GetChild(i).gameObject);
        }
    }

    public void RefreshView()
    {
        while(myStory.canContinue)
        {
            MakeNewDialogue(myStory.Continue());
        }
        if(myStory.currentChoices.Count > 0)
        {
            MakeNewChoices();
        }
        else
        {
            branchingCanvas.SetActive(false);
        }
        StartCoroutine(ScrollCo());
    }

    IEnumerator ScrollCo()
    {
        yield return null;
        dialogueScroll.verticalNormalizedPosition = 0f;
    }

    void MakeNewDialogue(string newDialogue)
    {
        DialogueObject newDialogueObject = Instantiate(dialoguePrefab, dialogueHolder.transform).GetComponent<DialogueObject>();
        newDialogueObject.Setup(newDialogue);
    }

    void makeNewResponse(string newDialogue, int choiceValue)
    {
        ResponseObject newResponseObject = Instantiate(choicePrefab, choiceHolder.transform).GetComponent<ResponseObject>();
        newResponseObject.Setup(newDialogue, choiceValue);
        Button responseButton = newResponseObject.gameObject.GetComponent<Button>();
        if (responseButton)
        {
            responseButton.onClick.AddListener(delegate{ ChooseChoice(choiceValue); });
        }
    }

    void MakeNewChoices()
    {
        for (int i = 0; i < choiceHolder.transform.childCount; i++)
        {
            Destroy(choiceHolder.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < myStory.currentChoices.Count; i++)
        {
            makeNewResponse(myStory.currentChoices[i].text, i);
        }
    }

    void ChooseChoice(int choice)
    {
        myStory.ChooseChoiceIndex(choice);
        RefreshView();
    }
}
