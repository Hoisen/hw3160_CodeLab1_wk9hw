using System.Collections;
using System.Collections.Generic;
using Mono.Cecil;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shopping : MonoBehaviour
{
    public Text display;

    public Text displayShoppingCart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayPlayerOwed();
        DisplayPlayerBuy();
    }
    //Dictionary - player owned items
    private Dictionary<string, int> playerOwned = new Dictionary<string, int>();
    //Dictionary - shopping cart
    private Dictionary<string, int> playerBuy = new Dictionary<string, int>();

    private Dictionary<string, int> fakeOne = new Dictionary<string, int>();

    public void AddResource(string resourceType, int amountToAdd)
    {
        if (playerBuy.ContainsKey(resourceType))//if you already have the resources(contains)
        {
            playerBuy[resourceType] = playerBuy[resourceType] + amountToAdd;//then add 1 values into the ready-owned resources
            
            //Debug.Log("You own " + playerBuy[resourceType] + " of " + resourceType);
        }
        else
        {
            playerBuy.Add(resourceType, amountToAdd);//if you dont have this kind of resource in your dictionary, add both things to it.
        }
    }
    public void DisplayPlayerBuy()//can make it to image chuansongdai
    {
        displayShoppingCart.text = "Items in your shopping car:\n";
    
        foreach (KeyValuePair<string, int> keyValuePair in playerBuy)//Dictionary
        {
            displayShoppingCart.text += "\n" + keyValuePair.Key + " (" + playerBuy[keyValuePair.Key] + ")";//find string or anything based on the what types of key --> [KeyValuePair.key] = "Gold", "Sliver"
        }
    }

    public void DisplayPlayerOwed()
    {
        display.text = "You purchased: \n";
    
        foreach (KeyValuePair<string, int> keyValuePair in playerOwned)//Dictionary
        {
            display.text += "\n" + keyValuePair.Key + " (" + playerOwned[keyValuePair.Key] + ")";//find string or anything based on the what types of key --> [KeyValuePair.key] = "Gold", "Sliver"
        }
    }
    
    public void AddResources(string resourceString)
    {
        AddResource(resourceString, 1);
    }
    
    // public void BuyItems(string item)
    // {
    //     var successfulPurchased = false;//default: we are unable to buy it
    //     //
    //     
    //     if (successfulPurchased)
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
    //
    // }
    
    public void BuyItems()
    {
        fakeOne = playerBuy;
        playerBuy = playerOwned;
        playerOwned = fakeOne;
        clearAll();
    }
    
    //next step -> Merge dictionaries
    
    //how to determine all the keys

    public void clearAll()
    {
        playerBuy.Clear();
    }
}
