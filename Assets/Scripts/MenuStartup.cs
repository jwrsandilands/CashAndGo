using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuStartup : MonoBehaviour
{
    public GameObject gameMenuUI;
    public GameObject pauseMenuUI;
    public GameObject gameOverMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        gameOverMenuUI.SetActive(false);
    }
}
