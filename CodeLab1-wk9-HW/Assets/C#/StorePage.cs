using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StorePage : MonoBehaviour
{
    public Text display;
    public Text displayMoney;

    private int playerMoney = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Each update, display the resources available to the player
        //DisplayResources();
        // And what items the player already has.
        //DisplayItems();
        
        //Store Page
        //Display all the items
        //DisplayStoreItems();

        //Player Page
        DisplayPlayerOwed();
        DisplayPlayerMoney();
    }
    
        
    // A dictionary to represent what resources they have. The key to finding these values, this key could be anything
    //private Dictionary<string, int> resourcesOwned = new Dictionary<string, int>();
    // A dictionary to represent what items they have.
    //private Dictionary<string, int> itemsOwned = new Dictionary<string, int>();
    
    //Dictionary - store items
    private Dictionary<string, int> storeOwned = new Dictionary<string, int>();
    
    //Dictionary - player owned items
    private Dictionary<string, int> playerOwned = new Dictionary<string, int>();

    //Add items to your shopping car!
    public void buyItems(string resourceType, int amountToAdd)
    {
        if (storeOwned.ContainsKey(resourceType))//if you already have the resources(contains)
        {
            storeOwned[resourceType] = storeOwned[resourceType] + 1;//amountToAdd;//then add 10 values into the ready-owned resources
            
            Debug.Log("you purchased " + resourceType);
        }
        else
        {
            storeOwned.Add(resourceType, 1); //amountToAdd);//if you dont have this kind of resource in your dictionary, add both things to it.
        }
    }
    
    //
    // public bool RemoveResource(string resourceType, int cost)
    // {
    //     if (playerMoney <= 0)//
    //     {
    //         return false;
    //     }
    //
    //     storeOwned[resourceType] = storeOwned[resourceType] - 1;
    //
    //     if (storeOwned[resourceType] == 0)//check to see if the resource down to 0, remove the key from screen.
    //         storeOwned.Remove(resourceType);
    //     
    //     return true;//successful purchased
    // }

    
    // public bool myMoney(string resourceType, int amount)
    // {
    //     if (!storeOwned.ContainsKey(resourceType) || storeOwned[resourceType] < amount)//if you dont have the resource or you dont have enough resources
    //         return false;
    //     
    //     return true;
    // }
    
    // This function adds 10 of a resource - used in the buttons.
    // public void AddResources(string resourceString)
    // {
    //     AddResource(resourceString, 1);
    // }

    // Displays the owned resources
    public void DisplayPlayerOwed()
    {
        display.text = "Owned Items:\n";

        foreach (KeyValuePair<string, int> keyValuePair in playerOwned)//Dictionary
        {
            display.text += "\n" + keyValuePair.Key + " (" + playerOwned[keyValuePair.Key] + ")";//find string or anything based on the what types of key --> [KeyValuePair.key] = "Gold", "Sliver"
        }
    }

    public void buyStuff()
    {
        Debug.Log("you purchased this, costed 10 usd");
        playerMoney -= 10;
    }
    
    public void DisplayPlayerMoney()
    {
        displayMoney.text = "Money: " + playerMoney;
    }

    // // Displays the items
    // public void DisplayItems()
    // {
    //     display.text += "\n\nItems:\n";
    //     
    //     foreach (var keyValuePair in itemsOwned)//just for itemsOwned Dictionary
    //     {
    //         display.text += "\n" + keyValuePair.Key + " (" + itemsOwned[keyValuePair.Key] + ")";//look up the value within the dictionary
    //     }
    // }


    // public void BuyItems(string item)
    // {
    //     var successfulPurchase = false;//default: we are unable to buy it
    //
    //     switch (item.ToUpper())
    //     {
    //         case "RACE" :
    //             successfulPurchase = RemoveResource("RACE", 10);//remove items from store page
    //             break;
    //         case "VEGE" :
    //             successfulPurchase = RemoveResource("GEMS", 5);
    //             break;
    //         case "CREPE" :
    //             successfulPurchase = RemoveResource("SPARKLES", 15);
    //             break;
    //     }
    //
    //     if (successfulPurchase)
    //     {
    //         if (playerOwned.ContainsKey(item.ToUpper()))
    //         {
    //             playerOwned[item.ToUpper()] = playerOwned[item.ToUpper()] + 1;
    //         }
    //         else
    //         {
    //             playerOwned.Add(item.ToUpper(), 1);
    //         }
    //     }
    // }
}
