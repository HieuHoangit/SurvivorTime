using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessControl : MonoBehaviour
{
    public Light sceneLight; // Đèn chính trong scene
    public Button increaseButton; // Nút tăng độ sáng
    public Button decreaseButton; // Nút giảm độ sáng
    public float intensityStep = 0.2f; // Bước tăng/giảm cường độ

    void Start()
    {
        // Đăng ký sự kiện cho các nút
        increaseButton.onClick.AddListener(IncreaseBrightness);
        decreaseButton.onClick.AddListener(DecreaseBrightness);
    }

    void IncreaseBrightness()
    {
        // Tăng cường độ ánh sáng
        sceneLight.intensity += intensityStep;
    }

    void DecreaseBrightness()
    {
        // Giảm cường độ ánh sáng
        sceneLight.intensity -= intensityStep;
    }
}

