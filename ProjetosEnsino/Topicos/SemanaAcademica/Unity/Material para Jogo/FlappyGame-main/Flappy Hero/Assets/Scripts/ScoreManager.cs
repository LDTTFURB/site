using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField]
    private TextMeshProUGUI _currentScoreText;

    [SerializeField]
    private TextMeshProUGUI _highScoreText;

    [SerializeField] private AudioClip m_scoreUp;

    private int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        _currentScoreText.text = _score.ToString();
        _highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        SoundManager.instance.PlaySound(m_scoreUp);
        UpdateHighScore();
    }
}
