using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    #region instance
    private static BulletPool _instance;
    public static BulletPool Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<BulletPool>();
                if (_instance == null)
                {
                    Debug.LogError("BulletPool object not found on scene");
                }

            }
            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    #endregion

    List<GameObject> _pooledBullets;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] int _initialPoolSize = 10;

    void Start()
    {
        _pooledBullets = new List<GameObject>();
        for (int i = 0; i < _initialPoolSize; i++){
            IncreasePool();
        }
    }
    
    public GameObject GetPooledBullet()
    {
        for(int i = 0; i < _pooledBullets.Count; i++)
        {
            if(!_pooledBullets[i].activeInHierarchy)
            {
                return _pooledBullets[i];
            }
        }
        return IncreasePool();
    }

    GameObject IncreasePool(){
        GameObject tempObj = Instantiate(_bulletPrefab);
        tempObj.transform.parent = transform;
        tempObj.SetActive(false);
        _pooledBullets.Add(tempObj);
        return tempObj;
    }
}
