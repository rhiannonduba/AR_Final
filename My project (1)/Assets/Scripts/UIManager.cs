using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //This is the start button on the Title Screen
    }

    public void StopScanButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //This button switches to the stop scan screen
    }

    public void ResumeScanButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //This button switches back to the scan screen
    }

    public void MyRecipeButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        //This button goes to the My Recipes Screen regardless if you're on the Scan or ScanOff Screen
    }

    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //This is a back button for the My Recipes Screen
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Quit!");
        //This is a universal quit button
    }

    public void GrilledCheeseScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //This is the button to the grilled cheese screen
    }

    public void ScallopedPotatoeScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        //This is the button to the Scalloped Potato Screen
    }

    public void ScallopedPotatoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }

    public void CapreseSalad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }

    public void CapreseSaladBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

    public void Omelette()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

    }

    public void OmeletteBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);

    }

    public void PapasConJuevo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);

    }

    public void PapasConJuevoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);

    }

    public void Shakshuka()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);

    }

    public void ShakshukaBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);

    }

    public void ChickenParm()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);

    }

    public void ChickenParmBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);

    }

    public void ChickenPotato()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);

    }

    public void ChickenPotatoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);

    }

}
