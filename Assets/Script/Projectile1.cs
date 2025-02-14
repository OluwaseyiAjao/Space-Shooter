using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    [SerializeField] GameObject LaserPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SpawnLaser()
    {
        Instantiate(LaserPrefab, transform.position, Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnLaser();
        }
    }
}
