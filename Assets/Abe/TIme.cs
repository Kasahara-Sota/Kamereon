using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TIme : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI uiText;

    private float startTime;

    private void Start()
    {
        // ゲーム開始時の時間を記録
        startTime = Time.time;
    }

    private void Update()
    {
        // 現在の経過時間を計算
        float elapsed = Time.time - startTime;

        int minutes = Mathf.FloorToInt(elapsed / 60f);
        int seconds = Mathf.FloorToInt(elapsed % 60f);

        // 表示形式を00:00に整形
        uiText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}