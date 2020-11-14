using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menu;
    public Text text;
    int heartCount;
    AudioSource heartSound;
    public GameObject gameover;


    private void Start()
    {
        heartSound = GetComponent<AudioSource>();
    }
    public void PauseMenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void getHeart(GameObject other)
    {
        heartCount++;
        text.text = heartCount.ToString();
        heartSound.Play();
        Destroy(other.gameObject);
    }

    public void Gameover()
    {
        gameover.SetActive(true);

        Time.timeScale = 0;
    }

}
