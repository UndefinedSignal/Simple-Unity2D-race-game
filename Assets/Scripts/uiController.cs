using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class uiController : MonoBehaviour
{
    private bool gameOver = false;
    private bool gameStart = false;

    public TextMeshProUGUI _scoreText;
    public GameObject _onGameOver;
    public GameObject _onGameStart;
    private float venhiclePoints = 0;
    private float totalScore = 0;

    public EngineSoundEmitter em;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameOver)
        {
            _onGameOver.SetActive(true); // false to hide, true to show
            //_onGameOver.GetComponent<Renderer>().enabled = false;
            em.Stop();
        }
        else if(gameStart)
        {
            totalScore = venhiclePoints + Mathf.FloorToInt(Time.timeSinceLevelLoad);
            _scoreText.text = "Score: " + totalScore;
        }
    }

    public void GameOverTrue()
    {
        em.Stop();
        gameOver = true;
        gameStart = false;
    }

    public void AddVenhiclePoint(float score)
    {
        if(!gameOver)
        {
            venhiclePoints += score;
        }
    }

    public void RestartGame()
    {
        em.Stop();
        em.Play();
        gameOver = false;
        gameStart = true;
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        em.Play();
        _onGameStart.SetActive(false);
        Time.timeScale = 1;
        gameStart = true;
    }
}
