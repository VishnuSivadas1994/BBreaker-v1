using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    [Range(0.1f,10f)][SerializeField] float gameSpeed=1f;
    // Use this for initialization
    [SerializeField] int pointsWhenBlockDestroyed = 50;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int currentScore = 0;



    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore += pointsWhenBlockDestroyed;

    }
	// Update is called once per frame
	void Update () {
        Time.timeScale =gameSpeed;
        scoreText.text = currentScore.ToString();

    }
}
