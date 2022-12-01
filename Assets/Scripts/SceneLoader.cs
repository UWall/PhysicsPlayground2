using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void BttnJogo1()
    {
        SceneManager.LoadScene("SimCity");
    }
    public void BttnJogo2()
    {
        SceneManager.LoadScene("FlappyBird");
    }
    public void BttnJogo3()
    {
        SceneManager.LoadScene("Kart");
    }
    public void Sair()
    {
        Application.Quit();
    }
}
