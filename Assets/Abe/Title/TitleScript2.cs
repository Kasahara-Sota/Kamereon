using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript2 : MonoBehaviour

{
    public void ClickStartButton(string sceneName) //押したら変更
    {
        SceneManager.LoadScene(sceneName);
    }
}
