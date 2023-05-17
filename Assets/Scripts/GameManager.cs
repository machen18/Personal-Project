using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOver;
    public Button restartButton;
    public Button startButton; 
    public GameObject hideObject;
    public GameObject titleScreen;
    public bool isGameActive;

    Start is called before the first frame update
    void Start()
    {
       startButton.onClick.AddListener(StartGame);

       void StartGame()
    {
        Debug.Log("start");
        hideObject.SetActive(false);
        
    }

    }

    Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame
    {
        isGameActive = true;

        //titleScreen.gameObject.SetActive(false);
    }
}