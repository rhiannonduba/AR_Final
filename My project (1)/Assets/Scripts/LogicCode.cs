using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LogicCode : MonoBehaviour
{
    public TestMarkerTracking TestMarkerTracking;

    
    List<string> ingredients = new List<string>(); //list of ingredients where items that are detected are brought in

    public static List<string> FoundRecipies = new List<string> { }; //if even one ingredient is found in a given, the recipie it's added to the list
    List<int> Counters = new List<int> { };

    Dictionary<string, string> recipies = new Dictionary<string, string>
    {  //list of recipies that are entered in (key is the name, value is the ingredients needed to make the recipie)
            { "Grilled Cheese","bread,cheese"},
            { "Scalloped Potatoes","potatoes,cheese"},
            { "Caprese Salad", "cheese,tomatoes"},
            { "Omelette", "cheese,eggs,tomatoes"},
            { "Papas Con Juevos", "eggs,potatoes"},
            { "Chicken Parmsean", "cheese,chicken,tomatoes,bread"},
            { "Shakshuka" , "tomatoes,eggs,cheese"},
            { "Roasted Chicken with Potatoes" , "chicken,potatoes"}
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
        ingredients.Add("eggs");

        // }


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

        int temp;
        string ingtemp;
        for (int j = 0; j <= Counters.Count - 2; j++)
        {
            for (int i = 0; i <= Counters.Count - 2; i++)
            {
                if (Counters[i] < Counters[i + 1])   //default is >
                {
                    temp = Counters[i + 1];
                    ingtemp = FoundRecipies[i + 1];
                    Counters[i + 1] = Counters[i];
                    FoundRecipies[i + 1] = FoundRecipies[i];
                    Counters[i] = temp;
                    FoundRecipies[i] = ingtemp;
                }
            }
        }

        /*for (var i = 0; i < Counters.Count; i++)
        {
            if (i == Counters.Count)
            {
                break;
            }
            else 
            {
                if (Counters[i] < Counters[i + 1])
                {

                }
            }
        }
        */

        Debug.Log("Display recipies list(fixed):");
        foreach (string item in FoundRecipies) 
        {
            Debug.Log(item);
        }


    }
}
