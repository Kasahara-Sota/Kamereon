using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChanegeScene(string StageName) //��������ύX
    {
        SceneManager.LoadScene(StageName);
    }
}

