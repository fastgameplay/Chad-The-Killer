using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject _startPanel;
    [SerializeField] GameObject _winPanel;

    public void StartStatus(bool active){
        _startPanel.SetActive(active);
    }

    public void WinStatus(bool active){
        _winPanel.SetActive(active);
    }
}
