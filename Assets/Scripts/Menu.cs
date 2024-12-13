using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Pindah ke Scene Menu
    public void LoadLevelScene()
    {
        SceneManager.LoadScene(1);
    }

    // Pindah ke Scene Asylum
    public void EasyLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void MediumLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void HardLevel()
    {
        SceneManager.LoadScene(4);
    }

    // Keluar dari Game
    public void QuitGame()
    {
        Debug.Log("Game Quit!");
        Application.Quit();
    }
}
