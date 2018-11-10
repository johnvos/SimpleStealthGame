using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour {

    private static int playerScore;
    private static int aiScore;

	void Start () {
        playerScore = 0;
        aiScore = 0;
	}


    //----------API---------
    public void AddPlayerScore() {
        playerScore++;
        Debug.Log("PlayerScore: " + playerScore);
    }

    public void AddAiScore() {
        aiScore++;
        Debug.Log("AIScore: " + aiScore);
    }

    public int GetPlayerScore() {
        return playerScore;
    }

    public int GetAiScore() {
        return aiScore;
    }


}
