using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _speed;
    [SerializeField] private Transform _startPoint;
    public bool IsBoosted = false;
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
        MidAir();
    }
    private void PlayJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onGround && IsBoosted == false)
        {
            _rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _onGround && IsBoosted == true)
        {
            _rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            IsBoosted = false;
        }
    }

    private void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _rigidbody.velocity = new Vector3(x * _speed, _rigidbody.velocity.y, z * _speed);
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(0, -0.1f, 0);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(0, 0.1f, 0);
        }
    }
    private void MidAir()
    {
        if (_onGround == false && gameObject.transform.position.y < -20f)
        {
            _rigidbody.velocity = Vector3.zero;
            gameObject.transform.position = _startPoint.position;
        }
    }

}

