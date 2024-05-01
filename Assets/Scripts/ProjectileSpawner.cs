using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private Projectile _projectile;

    public void Spawn(Transform spawnPoint)
    {
        Instantiate(_projectile, spawnPoint);
    }
}
