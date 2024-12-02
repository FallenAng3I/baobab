using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private ObjectPool bulletPool;
    [SerializeField] private Transform firePoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = bulletPool.TryGetFromPool();
        if (bullet != null)
        {
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
            bullet.GetComponent<Bullet>().Initialize(bulletPool);
        }
    }
}