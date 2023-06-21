using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    private void OnTriggerEnter(Collider other)
    {
        _player.velocity = Vector3.zero;
        _player.AddForce(Vector3.up * 15, ForceMode.Impulse);
    }
}
