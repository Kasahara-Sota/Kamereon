using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChanegeScene(string StageName) //押したら変更
    {
        SceneManager.LoadScene(StageName);
    }
}

