using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    private int _health = 100;
    private Text _text;

    public static HealthText Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            _text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _text.text = "Health: " + _health.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int value)
    {
        if (_health > 0)
        {
            _health -= value;
            _text.text = "Health: " + _health.ToString();
        }
    }
}
