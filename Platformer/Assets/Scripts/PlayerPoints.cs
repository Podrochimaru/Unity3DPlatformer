using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int Level1Counter = 0;
    [SerializeField] private Animator _animator;
    [SerializeField] private Animator _animator2;

    private void Update()
    {
        prikol();
    }
    private void prikol()
    {
        if (Level1Counter >= 2)
        {
            _animator.Play("Door");
            _animator2.Play("Door3");
            
        }
    }
    
}
