using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private Player player;
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject mainMenuButton;
    [SerializeField] private GameObject gameOver;

    private int score;
    public int Score => score;

    private void Awake()
    {
       
            Instance = this;
            gameOver.SetActive(false);
            Application.targetFrameRate = 60;
            
            Pause();    
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        mainMenuButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }

    public void GameOver()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);
        mainMenuButton.SetActive(true);


        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
       
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
   
     public void QuitGame()
    {
        Application.Quit();
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
