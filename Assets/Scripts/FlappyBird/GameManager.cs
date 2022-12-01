using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]private Text scoreText;
    private int score = 0;
    public static GameManager instance;
    void Start()
    {
        instance = this;
    }

    public void GainPoints()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void Reset()
    {
        SceneLoader.instance.LoadScene("Game2");
    }
}
