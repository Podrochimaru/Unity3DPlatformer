using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontTrampoline : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    private void OnTriggerEnter(Collider other)
    {
        _player.velocity = Vector3.zero;
        _player.AddForce(new Vector3(_player.velocity.x, 20, 0), ForceMode.Impulse);
        _player.AddForce(new Vector3(_player.velocity.x, 0, 2000), ForceMode.Impulse);
    }
}
