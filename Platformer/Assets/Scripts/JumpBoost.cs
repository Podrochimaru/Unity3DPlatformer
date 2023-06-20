using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    private void OnTriggerEnter(Collider other)
    {
        _movement.IsBoosted = true;
        Destroy(gameObject);
    }
}
