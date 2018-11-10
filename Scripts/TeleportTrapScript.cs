using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrapScript : MonoBehaviour {

    public GameController gc;

    private Collider[] listOfObjects;

    public void TeleportEnemy(Vector3 center, string user) {
        Collider enemy = DetectEnemy(center, user);

        if (enemy.gameObject.CompareTag("Enemy")) {
            if(enemy.bounds.center.z > 0) {
                gc.DecrementTopEnemyCount();
            } else {
                gc.DecrementBotEnemyCount();
            }
            Destroy(enemy.gameObject);
            Debug.Log("EnemyKilled");
        }

        if (enemy.gameObject.CompareTag("Player") || enemy.gameObject.CompareTag("AI")) {
            
            //************************
            //*** Need to work on ****
            //************************

            Debug.Log("Adversary Teleported!");
        }

        
    }

    private Collider DetectEnemy(Vector3 center, string user) {
        float radius = 0.0f;
        int layerMask = 1 << 9;
        while (radius < 55f) {
            listOfObjects = Physics.OverlapSphere(center, radius, layerMask);
            radius++;
            if (listOfObjects.Length >= 2) break;
        }

        
        Collider closestCollider = listOfObjects[0];
        for(int i = 0; i < listOfObjects.Length; i++) {
                
            float dist1 = Vector3.Distance(center, closestCollider.bounds.center);
            float dist2 = Vector3.Distance(center, listOfObjects[i].bounds.center);
                

            if(dist1 > dist2 || closestCollider.CompareTag(user)) {
                closestCollider = listOfObjects[i];
            }

        }

        return closestCollider;
       



    



    }
	



}
