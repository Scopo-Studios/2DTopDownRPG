using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureChest : Interactable
{

    public InventoryItem thisItem;
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
        if (Input.GetKeyDown(KeyCode.E) && playerInRange){
            if(!isOpen){
                OpenChest();
            }
            else {
                ChestAlreadyOpen();
            }
        }
    }

    public void OpenChest(){
        dialogBox.SetActive(true);
        dialogText.text = thisItem.itemDescription;

        // Add item to inventory
        if (playerInventory.myInventory.Contains(thisItem)) 
        {
            thisItem.numberHeld += 1;
        } 
        else 
        {
            playerInventory.myInventory.Add(thisItem);
            thisItem.numberHeld += 1;
        }
        
        raiseItem.Raise();
        
        context.Raise();
        isOpen = true;
        anim.SetBool("opened", true);
    }
    public void ChestAlreadyOpen(){
        
        dialogBox.SetActive(false);
        
        raiseItem.Raise();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen){
            context.Raise();
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen){
            context.Raise();
            playerInRange = false;
            
        }
    }
}
