using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Thêm dòng này

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textTimer;
    public TextMeshProUGUI winText; // Thêm dòng này
    int gameMode = 0;
    public int timer;
    private bool gameEnded = false; // Biến cờ để kiểm tra xem trò chơi đã kết thúc chưa

    private void Start()
    {
        gameMode = PlayerPrefs.GetInt("gameMode");
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        int showTimer = 0;
        int maxTimer = 0;
        if (gameMode == 0) maxTimer = 15;
        int second, minute;
        while (!gameEnded)
        {
            timer++;
            if (gameMode == 0)
            {
                showTimer = maxTimer - timer;
                if (timer >= maxTimer)
                {
                    winText.text = "Bạn đã chiến thắng!"; // Thêm dòng này
                    gameEnded = true; // Đặt cờ để kết thúc trò chơi
                    StartCoroutine(WinCountdown()); // Bắt đầu Coroutine đếm ngược 5 giây
                }
            }
            else
            {
                showTimer = timer;
            }

            second = showTimer % 60;
            minute = (showTimer / 60) % 60;
            textTimer.text = minute.ToString("00") + ":" + second.ToString("00");
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator WinCountdown()
    {
        int countdown = 5;
        while (countdown > 0)
        {
            winText.text = "Bạn đã chiến thắng! Chuyển qua màn 2 sau: " + countdown.ToString() + " giây";
            yield return new WaitForSeconds(1f);
            countdown--;
        }
        SceneManager.LoadScene("man2"); // Chuyển sang scene "man2"
    }
}
