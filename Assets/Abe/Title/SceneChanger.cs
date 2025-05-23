using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChanegeScene(string StageName) //‰Ÿ‚µ‚½‚ç•ÏX
    {
        SceneManager.LoadScene(StageName);
    }
}

