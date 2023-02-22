using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(PanelManager))] 
public class GameManager : MonoBehaviour
{
    public bool StartPanel{
        set{_panelManager.StartStatus(value);}
    }
    PanelManager _panelManager;
    
    void Awake(){
        _panelManager = GetComponent<PanelManager>();
    }
    public void Win(){
        _panelManager.WinStatus(true);
        StartCoroutine(IERestartAfter(3f));
    }

    IEnumerator IERestartAfter(float time)
    {
        
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);
    }
}
