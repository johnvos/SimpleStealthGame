using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    static private bool m_PlayerAlive;
    static private bool m_AiAlive;

    static private int m_topEnemyCount;
    static private int m_bottomEnemyCount;

    public Scoreboard scoreboard;

	void Start () {
        m_PlayerAlive = true;
        m_AiAlive = true;
        m_topEnemyCount = 0;
        m_bottomEnemyCount = 0;
	}
	
	void Update () {

        //All collectables are collected
        if(scoreboard.GetPlayerScore() + scoreboard.GetAiScore() == 10) {
            DeclareWinner();
        }

        //Both Player and Ai are dead
        if (!m_AiAlive && !m_PlayerAlive) {
            EndGame();
        }

	}

    private void EndGame() {
        
        //************************
        //*** Need to work on ****
        //************************

        //Debug.Log("GameEnd");
    }

    private void DeclareWinner() {

        //************************
        //*** Need to work on ****
        //************************

        if (scoreboard.GetPlayerScore() > scoreboard.GetAiScore()) {
            Debug.Log("PlayerWins!");
        }else if (scoreboard.GetPlayerScore() < scoreboard.GetAiScore()) {
            Debug.Log("AIWins!");
        }else if(scoreboard.GetPlayerScore() == scoreboard.GetAiScore()) {
            Debug.Log("Draw!!!");
        }
        
    }


    //-----------API-----------
    public void killPlayer() {
        //************************
        //*** Need to work on ****
        //************************
        //Debug.Log("PlayerDetected");
        m_PlayerAlive = false;
    }

    public void killAi() {
        //************************
        //*** Need to work on ****
        //************************
        //Debug.Log("AIDetected");
        m_AiAlive = false;
    }

    public int GetTopEnemyCount() {
        return m_topEnemyCount;
    }
    
    public int GetBotEnemyCount() {
        return m_bottomEnemyCount;
    }

    public void IncrementTopEnemyCount() {
        m_topEnemyCount++;
    }

    public void IncrementBotEnemyCount() {
        m_bottomEnemyCount++;
    }

    public void DecrementTopEnemyCount() {
        m_topEnemyCount--;
    }

    public void DecrementBotEnemyCount() {
        m_bottomEnemyCount--;
    }

}
