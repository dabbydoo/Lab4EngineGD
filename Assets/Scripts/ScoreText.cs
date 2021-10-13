using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private int _score;
    private Text _text;

    public static ScoreText Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            _text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _text.text = "Score: " + _score.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {

        _score += value;
        _text.text = "Score: " + _score.ToString();
    }
}
