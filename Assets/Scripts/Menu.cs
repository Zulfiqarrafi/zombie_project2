using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Pindah ke Scene Menu
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    // Pindah ke Scene Asylum
    public void LoadAsylumScene()
    {
        SceneManager.LoadScene("Asylum");
    }

    // Keluar dari Game
    public void QuitGame()
    {
        Debug.Log("Game Quit!");
        Application.Quit();
    }
}
