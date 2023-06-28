using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public void OpenCoinScene()
    {
        SceneManager.LoadScene("Coin Scene");
    }

    public void OpenCarScene()
    {
        SceneManager.LoadScene("Car Scene");
    }
}
