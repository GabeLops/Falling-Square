using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float m_speed;
    public float jump;
    

    private void Update()
    {
        Vector3 input = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
            input += Vector3.left;
        if (Input.GetKey(KeyCode.D))
            input += Vector3.right;

        input.Normalize();

        transform.position += input * m_speed * Time.deltaTime;
    }



}
