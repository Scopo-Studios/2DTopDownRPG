using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : Interactable
{
    public InventoryItem keyItem; // The specific key required
    public PlayerInventory playerInventory;
    public bool isOpen;
    public SignalSender raiseItem;
    public GameObject dialogBox;
    public Text dialogText;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && HasKey())
        {
            if (!isOpen)
            {
                OpenDoor();
            }
            else
            {
                DoorAlreadyOpen();
            }
        }
    }

    private bool HasKey()
    {
        return playerInventory.myInventory.Contains(keyItem) && keyItem.numberHeld > 0;
    }

    public void OpenDoor()
{
    dialogBox.SetActive(true);
    dialogText.text = "You used the key to unlock the door.";

    // Remove the key from inventory
    keyItem.numberHeld -= 1;
    if (keyItem.numberHeld <= 0)
    {
        playerInventory.myInventory.Remove(keyItem);
    }

    // Optional: Play door opening animation
    if (anim != null)
    {
        anim.SetBool("opened", true);
    }

    raiseItem.Raise();

    
    context.Raise(); 
    playerInRange = false;

    isOpen = true;

    // Finally deactivate the door object
    gameObject.SetActive(false);
}


    public void DoorAlreadyOpen()
    {
        dialogBox.SetActive(false);
        raiseItem.Raise();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = false;
        }
    }
}