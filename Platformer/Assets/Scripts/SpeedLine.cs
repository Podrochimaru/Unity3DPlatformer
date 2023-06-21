using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLine : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    private void OnTriggerStay(Collider other)
    {
        _movement.Speed = 15;
    }
    private void OnTriggerExit(Collider other)
    {
        _movement.Speed = 5;
    }
}
