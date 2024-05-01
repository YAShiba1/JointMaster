using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint;
    [SerializeField] private Transform _projectilePoint;
    [SerializeField] private float _shootForce;
    [SerializeField] private ProjectileSpawner _projectileSpawner;

    private void Start()
    {
        _projectileSpawner.Spawn(_projectilePoint);
    }

    private void Update()
    {
        Shoot();
        Reload();
    }

    private void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _springJoint.spring = _shootForce;
        }
    }

    private void Reload()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _springJoint.spring = 0;
            _projectileSpawner.Spawn(_projectilePoint);
        }
    }
}
