using UnityEngine;
using TPM_Text = TMPro.TextMeshProUGUI;
public class PointSystem : MonoBehaviour
{

    public static PointSystem Instance;
    public TPM_Text scoreText;

    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        
    }

    public void Start()
    {
        UpdateScore();
    }

    public void AddPoints(int points)
    {
        score += points;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

}
