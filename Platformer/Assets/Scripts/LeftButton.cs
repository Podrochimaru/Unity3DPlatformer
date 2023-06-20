using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    [SerializeField] private PlayerPoints _player;
    private bool _alreadyused = false;
    private void OnTriggerEnter(Collider other)
    {
        if (_alreadyused == false)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            _player.Level1Counter += 1;
            _alreadyused = true;
        }
    }
}
