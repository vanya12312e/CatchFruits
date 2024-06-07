using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;

    public Text livesText;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private Color blackColor;
    [SerializeField] private Color whiteColor;

    void Start()
    {
        currentLives = maxLives;
        UpdateLivesUI();
        HidePanel();
    }

    void UpdateLivesUI()
    {
        livesText.text = "Lives: " + currentLives.ToString();
    }

    public void LoseLife()
    {
        if (currentLives > 0)
        {
            currentLives--;
            UpdateLivesUI();

            if (currentLives == 0)
            {
                Debug.Log("Game Over");
                losePanel.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                Camera.main.backgroundColor = blackColor;
            }
        }
    }

    public void GainLife()
    {
        if (currentLives < maxLives)
        {
            currentLives++;
            UpdateLivesUI();
        }
    }

   

    public void HidePanel()
    {
        Time.timeScale = 1;
        losePanel.SetActive(false);
        Camera.main.backgroundColor = whiteColor;
    }
    public void ShowPanel()
    {

        Debug.Log("Game Over");
        losePanel.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        Camera.main.backgroundColor = blackColor;

    }
}

