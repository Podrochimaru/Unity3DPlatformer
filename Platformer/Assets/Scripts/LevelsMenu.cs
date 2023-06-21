using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    public void Panel()
    {        
        if (_panel.activeSelf)
        {   
            _panel.SetActive(false);
        }
        else if (!_panel.activeSelf)
        {
            _panel.SetActive(true);
        }
    }
}
