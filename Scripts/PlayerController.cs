using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int MovementSpeed = 5;

    private Rigidbody m_rb;
    private Transform m_tr;
    private int teleportTrap;

    private void Start() {
        m_rb = GetComponent<Rigidbody>();
        m_tr = GetComponent<Transform>();
        teleportTrap = 2;
    }

    void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Move(x, y);

        if (Input.GetKeyDown(KeyCode.Space) && teleportTrap > 0) {

            this.GetComponent<TeleportTrapScript>().TeleportEnemy(m_tr.position, "Player");
            teleportTrap--;
        }

	}

    private void Move(float x, float y) {

        m_rb.velocity = (Vector3.forward * y + Vector3.right * x).normalized * MovementSpeed;
        
        if(x != 0.0f || y != 0.0f) {
            m_tr.forward = m_rb.velocity;
        }
    }



}
