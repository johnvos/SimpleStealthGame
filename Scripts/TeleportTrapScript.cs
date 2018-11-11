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

            int teleportTo = Random.Range(0, 10);

            enemy.gameObject.GetComponent<Transform>().SetPositionAndRotation(spawnPlacesArray[teleportTo], Quaternion.identity);

            
        }

        
    }

    private Collider DetectEnemy(Vector3 center, string user) {
        float radius = 0.0f;
        int layerMask = 1 << 9;
        while (radius < 55f) {
            listOfObjects = Physics.OverlapSphere(center, radius, layerMask);
            radius++;
            if (listOfObjects.Length >= 3) break;
        }

        
        Collider closestCollider = listOfObjects[0];
        for(int i = 0; i < listOfObjects.Length; i++) {
            if (!listOfObjects[i].gameObject.CompareTag(user)) {
                float dist1 = Vector3.Distance(center, closestCollider.bounds.center);
                float dist2 = Vector3.Distance(center, listOfObjects[i].bounds.center);


                if (dist1 > dist2 || closestCollider.gameObject.CompareTag(user)) {
                    closestCollider = listOfObjects[i];
                }

            }

        }

        return closestCollider;
       
        

    }
	



}
