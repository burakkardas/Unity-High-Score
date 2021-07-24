using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_Text _highScoreText;
    
    void Start() {
        _highScoreText.text = PlayerPrefs.GetInt("_highScore").ToString();
    }
    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}
