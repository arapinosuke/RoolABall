using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    /// <summary>
    /// 球のRigidbody
    /// </summary>
    private Rigidbody m_sphereRigidBody;

    /// <summary>
    /// キーボードのインプットを代入するVector3
    /// </summary>
    private Vector3 m_inputAxis = Vector3.zero;


    /// <summary>
    /// 球の加速度
    /// </summary>
    public float SphereAcceleration = 1.0f;


	// Use this for initialization
	void Start ()
    {
        m_sphereRigidBody = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        m_inputAxis.Set(Input.GetAxis("Horizontal") * SphereAcceleration, 0, Input.GetAxis("Vertical") * SphereAcceleration);
        m_sphereRigidBody.AddForce(m_inputAxis);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
