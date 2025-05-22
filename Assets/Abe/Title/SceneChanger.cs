using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneChanger : MonoBehaviour
{
    public void ChanegeScene(string StageName) //‰Ÿ‚µ‚½‚ç•ÏX
    {
        SceneManager.LoadScene(StageName);
    }
}

