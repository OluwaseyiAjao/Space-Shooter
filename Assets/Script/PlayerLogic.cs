using UnityEngine;


    


public class Week4Code : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }






    

// Update is called once per frame
    void Update()
    {
        
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(verticalInput * Vector2.up * Time.deltaTime * speed);
        transform.Translate(horizontalInput * Vector2.right * Time.deltaTime * speed);
    }
}
