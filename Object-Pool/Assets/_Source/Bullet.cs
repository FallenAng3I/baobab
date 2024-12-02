using UnityEngine;

public class Bullet : MonoBehaviour
{
    private readonly float _lifetime = 2f;
    private ObjectPool _pool;

    public void Initialize(ObjectPool objectPool)
    {
        _pool = objectPool;
    }

    private void OnEnable()
    {
        Invoke(nameof(Deactivate), _lifetime);
    }

    private void Deactivate()
    {
        _pool?.ReturnToPool(gameObject);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * (10f * Time.deltaTime));
    }
}