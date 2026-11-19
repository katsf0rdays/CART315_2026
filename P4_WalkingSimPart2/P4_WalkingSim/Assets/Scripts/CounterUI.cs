using UnityEngine;
using TMPro;

public class CounterUI : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public string prefix = "Bubbles Collected: ";
    public int maxCount = 20;
    public bool showMaxInText = true; // Shows "0 / 20" if checked, or just "0" if unchecked

    [Header("Win Screen")]
    public GameObject winScreenPanel;
    public bool unlockCursorOnWin = true;
    private int count = 0;
    private bool hasWon = false;

    void Start()
    {
        if (winScreenPanel != null)
        {
            winScreenPanel.SetActive(false);
        }

        UpdateDisplay();
    }

    public void AddToCounter(int amount = 1)
    {
        if (hasWon) return;

        count = Mathf.Min(count + amount, maxCount);
        UpdateDisplay();

        if (count >= maxCount)
        {
            ShowWinScreen();
        }
    }

    private void ShowWinScreen()
    {
        hasWon = true;

        if (winScreenPanel != null)
        {
            winScreenPanel.SetActive(true);
        }

        if (unlockCursorOnWin)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void UpdateDisplay()
    {
        if (counterText != null)
        {
            if (showMaxInText)
            {
                counterText.text = prefix + count + " / " + maxCount;
            }
            else
            {
                counterText.text = prefix + count;
            }
        }
    }
}