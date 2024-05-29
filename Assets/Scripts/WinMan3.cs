using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinMan3 : MonoBehaviour
{
    public TextMeshProUGUI winText3;
    private int enemiesKilled = 0;
    private bool gameEnded = false;

    public void EnemyKilled()
    {
        enemiesKilled++;
        if (enemiesKilled == 1 && !gameEnded) // Nếu số kẻ địch bị tiêu diệt đạt 1 và trò chơi chưa kết thúc
        {
            gameEnded = true;
            winText3.text = "Bạn đã chiến thắng!";
            StartCoroutine(CountdownAndSwitchScene());
        }
    }

    IEnumerator CountdownAndSwitchScene()
    {
        yield return new WaitForSeconds(5f); // Đợi 5 giây

        // Chuyển scene sang "menu"
        SceneManager.LoadScene("menu");
    }
}
