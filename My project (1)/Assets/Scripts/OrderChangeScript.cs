using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class OrderChangeScript : MonoBehaviour
{
    LogicCode LogicCode;
    List<string> OrderedRecipieList = new List<string>();
    public GameObject RecipieCard;
    public Transform[] RCList;
    public GameObject RecipieList;
    public List<GameObject> matchedItems;

    // Start is called before the first frame update
    void Start()
    {
        RecipieList = GameObject.FindGameObjectWithTag("RecipieList");
        Debug.Log(RecipieList);
        RCList = RecipieList.GetComponentsInChildren<Transform>();
        OrderedRecipieList = LogicCode.FoundRecipies;

        Debug.Log("---Derived List from Logic Code----");
        foreach (string item in OrderedRecipieList)
        {
            Debug.Log(item);
        }
        Debug.Log("-----------------------------------");

        foreach (Transform children in RCList)
        {
            children.gameObject.SetActive(true);
            Debug.Log(children.gameObject + "activated");

            foreach (string recipie in OrderedRecipieList)
            { 
                if (children.gameObject.tag == recipie)
                {
                    matchedItems.Add(children.gameObject);
                }

            }

            if (!matchedItems.Contains(children.gameObject))
            {
                continue;
            }
            else
            {
                children.gameObject.SetActive(false);
                Debug.Log(children.gameObject + "activated");
            }


        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
