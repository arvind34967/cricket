using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI wicketsText;
    public TextMeshProUGUI ballsText;
    
    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    
    public void UpdateScore(int runs, int wickets)
    {
        scoreText.text = $"Score: {runs}";
        wicketsText.text = $"Wickets: {wickets}";
    }
    
    public void UpdateBalls(int remaining)
    {
        ballsText.text = $"Balls: {remaining}";
    }
}