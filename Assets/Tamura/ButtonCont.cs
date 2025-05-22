using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bu : MonoBehaviour
{
    public void ChangeScene(string StageName) 
    {
        SceneManager.LoadScene(StageName);
    }
}
