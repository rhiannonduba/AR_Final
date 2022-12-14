using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LogicCode : MonoBehaviour
{
    public TestMarkerTracking TestMarkerTracking;
    

    List<string> ingredients = new List<string>(); //list of ingredients where items that are detected are brought in

    Dictionary<string, string> recipies = new Dictionary<string, string>
    {  //list of recipies that are entered in (key is the name, value is the ingredients needed to make the recipie)
            { "Pasta salad","tomatoes,pasta" },
            { "Potato Salad","potatoes,tomatoes" },
            { "French Toast", "eggs,bread"},
            { "Shakshouka" , "tomatoes,eggs"}
    };

    bool ingredientfound = false;

    // Start is called before the first frame update
    void Start()
    {
      //Loop here until the user hits the "finish scanning" button {
        //string newDetected = TestMarkerTracking.imageName;
        //ingredients.Add(newDetected);
        

      //Simulates scanned ingredients getting added (only for debug)
        ingredients.Add("tomatoes");
        ingredients.Add("potatoes");

        // }

        

        List<string> FoundRecipies = new List<string> { }; //if even one ingredient is found in a given, the recipie it's added to the list
        List<int> Counters = new List<int> { };

        foreach (KeyValuePair<string, string> recipie in recipies)
        {
            int counter = 0; //keeps counts how many of the ingredients in the ingredients list are found in each recipie
            string IngList = recipie.Value; //variable for storing valid ingredients for each recipie

            ingredientfound = false;

            foreach (string ing in ingredients) //iterates through each item in ingredients list
            {
                if (IngList.Contains(ing)) //if ingredient fron ingredient list matches with the valid ingredients in dictionary..
                {
                    counter += 1;
                    ingredientfound = true;
                    Debug.Log(ing + " found in " + recipie.Key);
                }

            }
            if (ingredientfound)
            {
                FoundRecipies.Add(recipie.Key);
                Counters.Add(counter);
            }


        }

        foreach( int i in Counters)
        {
            if (Counters[i] > )
            {

            }

        }

        Debug.Log("Display recipies list(fixed):");
        foreach (string item in FoundRecipies) 
        {
            Debug.Log(item);
        }


    }
}
