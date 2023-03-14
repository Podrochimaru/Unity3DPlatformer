using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _speed;
    private bool _onGround = true;

    private void OnCollisionEnter(Collision collision)
    {

        _onGround = true;

    }
    private void OnCollisionExit(Collision collision)
    {

        _onGround = false;

    }
    void Update()
    {
        PlayJump();
        PlayerMove();
    }
    private void PlayJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
        }
    }

    private void PlayerMove()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _rigidbody.velocity = new Vector3(x * _speed, _rigidbody.velocity.y, z * _speed);

    }

}

