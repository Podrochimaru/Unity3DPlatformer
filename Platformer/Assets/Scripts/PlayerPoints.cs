using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int Level1Counter = 0;
    [SerializeField] private Animator _animator;

    private void Update()
    {
        prikol();
    }
    private void prikol()
    {
        if (Level1Counter >= 2)
        {
            _animator.Play("Door");
        }
    }
    
}
