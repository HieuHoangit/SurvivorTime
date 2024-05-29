using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Killed : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI winText2; // Thêm tham chiếu tới WinText2
    public int currentKilled = 0;
    private bool gameEnded = false; // Biến để kiểm tra xem trò chơi đã kết thúc chưa

    private void Start()
    {
        text.text = "0";
    }

    public void UpdateKilled()
    {
        currentKilled++;
        text.text = currentKilled.ToString();

        if (SceneManager.GetActiveScene().name == "man3" && currentKilled == 1 && !gameEnded) // Kiểm tra nếu đang ở scene "man3" và currentKilled == 1
        {
            StartCoroutine(WinCountdownAndSwitchScene());
        }
        else if (currentKilled == 10 && !gameEnded && SceneManager.GetActiveScene().name != "man3") // Kiểm tra nếu không phải ở scene "man3" và currentKilled == 10
        {
            StartCoroutine(WinCountdownAndSwitchScene());
        }
    }


    IEnumerator WinCountdownAndSwitchScene()
    {
        gameEnded = true; // Đánh dấu rằng trò chơi đã kết thúc

        int countdown = 5;
        while (countdown > 0)
        {
            if (SceneManager.GetActiveScene().name == "man3") // Kiểm tra nếu đang ở scene "man3"
            {
                winText2.text = "Bạn đã chiến thắng! Chuyển sang menu sau: " + countdown.ToString() + " giây"; // Thay đổi thông báo nếu ở scene "man3"
            }
            else
            {
                winText2.text = "Bạn đã chiến thắng! Chuyển qua màn 3 sau: " + countdown.ToString() + " giây"; // Thay đổi thông báo nếu không ở scene "man3"
            }
            yield return new WaitForSeconds(1f);
            countdown--;
        }
        if (SceneManager.GetActiveScene().name == "man3") // Kiểm tra nếu đang ở scene "man3"
        {
            SceneManager.LoadScene("menu"); // Chuyển sang scene "menu" thay vì "man3"
        }
        else
        {
            SceneManager.LoadScene("man3"); // Chuyển sang scene "man3" nếu không ở scene "man3"
        }
    }
}
