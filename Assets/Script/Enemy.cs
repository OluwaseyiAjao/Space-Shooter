using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Gone()
    { 
        FindFirstObjectByType<GameManager>().Score();
       Destroy(gameObject);
    }

    public void End()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.down * speed * Time.deltaTime);
       if (transform.position.y < -5)
       {
           FindObjectOfType<GameManager>().GameOver();
       }
    }
}
