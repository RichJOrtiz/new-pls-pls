using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

	[Range(0.1f, 10f)] [SerializeField] float timeSpeed;
	[SerializeField] int pointsPerBlock;
    [SerializeField] int currentScore = 0;
	//[SerializeField] Text scoreText;

    private void Start()
    {
        // scoreText.text = currentScore.ToString();
    }
    // Update is called once per frame
    void Update () {
		Time.timeScale = timeSpeed;	
	}
    public void addToScore()
    {
		currentScore+= pointsPerBlock;
       //scoreText.text = currentScore.ToString();
    }

}
