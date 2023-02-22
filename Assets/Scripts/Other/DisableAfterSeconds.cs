using System.Collections;
using UnityEngine;

public class DisableAfterSeconds : MonoBehaviour
{
    [SerializeField] float _disableAfterSeconds;

    void Start(){
        StartCoroutine(DisableAfter(_disableAfterSeconds));
    }

    IEnumerator DisableAfter(float time){
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}
