using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject hudPanel;
    public GameObject gameOverPanel;

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        hudPanel.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    public void StartGame()
    {
        mainMenuPanel.SetActive(false);
        hudPanel.SetActive(true);
        gameOverPanel.SetActive(false);

        // code to trigger the traffic spawning will be here later
    }

    public void ShowGameOver()
    {
        mainMenuPanel.SetActive(false);
        hudPanel.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}
