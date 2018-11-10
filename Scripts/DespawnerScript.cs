using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnerScript : MonoBehaviour {

    public GameController gc;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {

            if(this.transform.position.z > 0) {
                gc.DecrementTopEnemyCount();
            } else {
                gc.DecrementBotEnemyCount();
            }

            Destroy(other.gameObject);
        }
        
    }
}
