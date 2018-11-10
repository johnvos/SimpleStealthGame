using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSpawner : MonoBehaviour {

    public GameController gc;
    public GameObject enemyPrefab;

    private Transform m_tr;

    void Start() {
        m_tr = GetComponent<Transform>();
    }

    void Update() {

        if (gc.GetTopEnemyCount() < 1) {
            Spawn();
        }
    }

    private void Spawn() {
        Instantiate(enemyPrefab, m_tr.position + m_tr.forward*2, Quaternion.Euler(0, 90, 0));
        gc.IncrementTopEnemyCount();
    }


}
