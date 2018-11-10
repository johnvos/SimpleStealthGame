using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour {

    public GameController gc;
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
            RandomAction(other);
        }

    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Enemy")) {
            other.GetComponentInChildren<EnemyVisionScript>().SetInBlock(false);
        }
    }


    private void RandomAction(Collider other) {
        int choice = Random.Range(0,3);

        //0: enemy disappears
        //1: enemy walks through
        //2: enemy changes direction
        switch (choice) {
            case 0:
                if(this.transform.position.z > 0) {
                    gc.DecrementTopEnemyCount();
                } else {
                    gc.DecrementBotEnemyCount();
                }
                Destroy(other.gameObject);
                break;
            case 1:
                other.GetComponentInChildren<EnemyVisionScript>().SetInBlock(true);
                break;
            case 2:
                other.gameObject.GetComponent<EnemyMovementScript>().Flip();
                break;
        }
    }




    
}
