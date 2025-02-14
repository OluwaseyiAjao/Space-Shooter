using UnityEngine;

public class LaserLogic : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
}
