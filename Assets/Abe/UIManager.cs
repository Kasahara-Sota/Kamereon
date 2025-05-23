using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Transform HeartIconsParent;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject GameClearUI;
    // Start is called before the first frame update
    void Start()
    {
        GameOverUI.SetActive(false);
        GameClearUI.SetActive(false);
    }
    public void DegreeHeartUI()
    {
        Destroy(HeartIconsParent.GetChild(HeartIconsParent.childCount - 1).gameObject);
        if(HeartIconsParent.childCount == 0)
        {
            ShowUI(GameOverUI);
        }
    }
    public void ShowUI(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
}

