using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int score;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private Button restartButton;

    [SerializeField] public bool gameIsActive = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    [ContextMenu("Test Score")]
    public void Score()
    {
        score += 1;
        scoreText.text = "Score " + score.ToString();

    }
    
    
    
    [ContextMenu("Game Over")]
    public void GameOver()
    {
        gameIsActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        
    }

    

    public void Restart()
    {
        SceneManager.LoadScene("Main"); 
    }


    void Update()
    {

    }
}
