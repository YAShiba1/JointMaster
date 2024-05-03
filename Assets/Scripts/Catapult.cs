using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint;
    [SerializeField] private Transform _projectilePoint;
    [SerializeField] private float _shootForce;
    [SerializeField] private ProjectileSpawner _projectileSpawner;

    private readonly int LeftMouseButtonCode = 0;
    private readonly int RightMouseButtonCode = 1;

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
        if(Input.GetMouseButtonDown(LeftMouseButtonCode))
        {
            _springJoint.spring = _shootForce;
        }
    }

    private void Reload()
    {
        if (Input.GetMouseButtonDown(RightMouseButtonCode))
        {
            _springJoint.spring = 0;
            _projectileSpawner.Spawn(_projectilePoint);
        }
    }
}
