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
        // �Q�[���J�n���̎��Ԃ��L�^
        startTime = Time.time;
    }

    private void Update()
    {
        // ���݂̌o�ߎ��Ԃ��v�Z
        float elapsed = Time.time - startTime;

        int minutes = Mathf.FloorToInt(elapsed / 60f);
        int seconds = Mathf.FloorToInt(elapsed % 60f);

        // �\���`����00:00�ɐ��`
        uiText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}