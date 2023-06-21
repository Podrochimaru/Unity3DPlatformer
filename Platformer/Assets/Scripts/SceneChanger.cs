using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string _scene;
    public void SceneLoad()
    {
        SceneManager.LoadScene(_scene);
    }
}
