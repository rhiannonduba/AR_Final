using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawn : MonoBehaviour
{
    LogicCode LogicCode;
    List<string> OrderedRecipieList = new List<string>();
    public GameObject RecipieList;
    public List<GameObject> matchedItems;

    // Start is called before the first frame update
    void Start()
    {
        RecipieList = GameObject.FindGameObjectWithTag("RecipieList"); //object initialized
        Debug.Log(RecipieList);
        OrderedRecipieList = LogicCode.FoundRecipies;  //og list
        Debug.Log(OrderedRecipieList);

        foreach(string recipie in OrderedRecipieList)
        {
            GameObject Button = Instantiate(Resources.Load(recipie, typeof(GameObject))) as GameObject;
            Button.SetActive(true);
            Button.transform.SetParent(RecipieList.transform);
        }
    }

}
