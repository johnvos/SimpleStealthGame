using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour {

    public Scoreboard scoreboard;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            scoreboard.AddPlayerScore();
            Destroy(this.gameObject);
        }
        if (other.CompareTag("AI")) {
            scoreboard.AddAiScore();
            Destroy(this.gameObject);
        }



    }



}
