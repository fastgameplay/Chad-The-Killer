using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _bulletSpawnPoint;
    [SerializeField] LayerMask _layersToHit;
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            ShootBullet();
        }

    }



    void ShootBullet(){
        Vector3 MousePos = Input.mousePosition; 
        Ray ray = Camera.main.ScreenPointToRay(MousePos);
        GameObject bullet = Instantiate (_bulletPrefab, _bulletSpawnPoint.position, Quaternion.identity);
        if(Physics.Raycast(ray, out RaycastHit hitData, 100, _layersToHit) ){
            bullet.transform.LookAt(hitData.point);
            return;
        }
        MousePos.z = 100;
        bullet.transform.LookAt(Camera.main.ScreenToWorldPoint(MousePos));
    }
}
