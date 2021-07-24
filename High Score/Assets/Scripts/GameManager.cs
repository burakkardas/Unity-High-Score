using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text _scoreText;
    public int _score;
    void Start()
    {
        _score = 0;
    }

    void Update()
    {
        _scoreText.text = _score.ToString();

        if(_score > PlayerPrefs.GetInt("_highScore")) {
            PlayerPrefs.SetInt("_highScore", _score);
        }
    }
    public void GameOver() {
        SceneManager.LoadScene(0);
    }
}
