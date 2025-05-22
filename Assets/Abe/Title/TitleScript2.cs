using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript2 : MonoBehaviour

{
    public void ClickStartButton(string sceneName) //‰Ÿ‚µ‚½‚ç•ÏX
    {
        SceneManager.LoadScene(sceneName);
    }
}
