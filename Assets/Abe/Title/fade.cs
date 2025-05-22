using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
public class fade : MonoBehaviour
{

    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float fadeTime;
    private void Start()
    {
        FadeOut();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            FadeIn();
        if (Input.GetKey(KeyCode.A))
            FadeOut();
    }
    private void FadeIn()//�F������@�s�����ɂ���
    {
        canvasGroup.alpha = 0f;
        canvasGroup.DOFade(1, fadeTime);
    }
    private void FadeOut()//�F���Ȃ����@�����ɂ���
    {
        canvasGroup.alpha = 1f;
        canvasGroup.DOFade(0, fadeTime);
    }
}

