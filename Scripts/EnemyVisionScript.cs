using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisionScript : MonoBehaviour {

    public GameController gc;

    private bool inBlock;

    private void Start() {
        inBlock = false;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            gc.killPlayer();
        }

        if (other.CompareTag("AI")) {
            gc.killAi();
        }
    }
    
    public void SetInBlock(bool condition) {
        inBlock = condition;
        this.GetComponent<Collider>().enabled = !inBlock;
        this.GetComponent<MeshRenderer>().enabled = !inBlock;
    }



}
