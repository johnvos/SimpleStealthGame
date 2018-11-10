using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour {

    public int MovementSpeed = 2;

    private Rigidbody m_rb;
    private Transform m_tr;

    private void Start() {
        m_rb = GetComponent<Rigidbody>();
        m_tr = GetComponent<Transform>();
    }

    private void Update() {
        Move();
        
    }


    private void Move() {
        m_rb.velocity = m_tr.forward * MovementSpeed;
    }

    public void Flip() {
        m_tr.forward = -m_tr.forward;
    }




}
