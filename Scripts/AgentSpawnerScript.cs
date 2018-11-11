using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSpawnerScript : MonoBehaviour {

    public GameObject Player;
    public GameObject AI;

	void Start () {
        int playerSpawn = Random.Range(0, 10);
        int aiSpawn = Random.Range(0, 10);
        //in case playerSpawn == aiSpawn which will result in both of them spawning at the same exact coordinate
        while (aiSpawn == playerSpawn) {
            aiSpawn = Random.Range(0, 10);
        }


        Vector3[] spawnPlacesArray = {
            //top half
            new Vector3(-17,0,15),
            new Vector3(-9,0,15),
            new Vector3(-1,0,15),
            new Vector3(7,0,15),
            new Vector3(15,0,15),
            //bottom half
            new Vector3(-15,0,-15),
            new Vector3(-7,0,-15),
            new Vector3(1,0,-15),
            new Vector3(9,0,-15),
            new Vector3(17,0,-15),
        };


        Spawn(Player, spawnPlacesArray[playerSpawn]);
        Spawn(AI, spawnPlacesArray[aiSpawn]);
        

	}

    private void Spawn(GameObject agent, Vector3 spawnPlace) {

        Instantiate(agent, spawnPlace, Quaternion.identity);

    }
	




}
