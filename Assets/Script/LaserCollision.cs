using Unity.VisualScripting;
using UnityEngine;

public class LaserCollision : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy hit  = collision.gameObject.GetComponent<Enemy>();
        if (hit != null)
        {
            hit.Gone();
           
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
