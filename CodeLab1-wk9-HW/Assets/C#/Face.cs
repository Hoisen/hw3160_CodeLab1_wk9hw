using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    // private int x = 5;
    // private int y = 4;
    public float xOffset;
    public float yOffset;

    public GameObject leftEar;
    //public GameObject rightEar;
    public GameObject mouse;
    public GameObject nose;
    public GameObject leftEye;
    //public GameObject rightEye;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void filltheFace()
    // {
    //     for (int i = 0; i < lineChars.Length; i++)
    //     {
    //         //get the current char
    //         char c = lineChars[i];
    //         //make a variable for a new GameObject
    //         GameObject newObj = null;
    //
    //         switch (c)
    //         {
    //             case 'w':
    //                 newObj = Instantiate<GameObject>(wall);
    //                 break;
    //             case '^':
    //                 newObj = Instantiate<GameObject>(spike);
    //                 break;
    //             case 'D':
    //                 newObj = Instantiate<GameObject>(door);
    //                 break;
    //             default:
    //                 newObj = null;
    //                 break;
    //         }
    //
    //         if (newObj != null)
    //         {
    //             //position it based on where it was
    //             //in the file
    //             newObj.transform.position = new Vector2(xOffset + i, yOffset -yPos);
    //             newObj.transform.parent = level.transform;
    //         }
    // }
}
