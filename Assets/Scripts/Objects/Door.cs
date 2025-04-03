using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorType
{
key,
enemy,
button
}

public class Door : Interactable
{
    [Header ("Door Variables")]
    public DoorType thisDoortype;
    public bool open = false;
    public Inventory playerInventory;
    public SpriteRenderer doorSprite;
    public BoxCollider2D physicsCollider;

    
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(playerInRange && thisDoortype == DoorType.key)
            {
                //Does the Player have a key?
                if(playerInventory.numberOfKeys > 0)
                {
                    playerInventory.numberOfKeys--;
                    Open();
                }
                // If so call the open method
            }
        }
    }

    public void Open()
    {
        // Turn off the door sprite renderer
        doorSprite.enabled = false;
        // set open to true
        open = true;
        // turn of the door box collider
        physicsCollider.enabled = false;
    }
    public void Close()
    {
    
    }
}

