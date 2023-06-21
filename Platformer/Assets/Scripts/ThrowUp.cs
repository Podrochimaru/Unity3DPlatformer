using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThrowUp : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    private void OnTriggerEnter(Collider other)
    {
        _player.velocity = Vector3.zero;
        _player.AddForce(Vector3.up * 100, ForceMode.Impulse);
        Invoke("SceneChanger", 1.5f);
    }
    private void SceneChanger()
    {
        SceneManager.LoadScene("Level2");
    }
}
