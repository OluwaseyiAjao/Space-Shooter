using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject Meteor;
    [SerializeField] float spawn_rate = 50;

    float elapsed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    
    void Update()
    {
        
        if (FindObjectOfType<GameManager>().gameIsActive) 
        {
            EnemySpawn();
        }

    }

    public void EnemySpawn()
    {
        elapsed += Time.deltaTime;

        if (elapsed > spawn_rate)
        {
            elapsed = 0;

            //Position

            float ranx = Random.Range(-10f, 10f);
            float rany = 6f;

            Vector2 spawn = new Vector2(ranx, rany);

            Instantiate(Meteor, spawn, Quaternion.identity);

            // Update is called once per frame

        }

    }

}        