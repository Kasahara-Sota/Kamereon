using UnityEngine;

public class Respawn : MonoBehaviour
{
    //初期位置をRespawnPositionとして設定
    Vector2 RespawnPosition = new Vector2();
    void Start()
    {
        RespawnPosition = transform.localPosition;
    }
    public void PlayerRespawn()
    {
        transform.localPosition = RespawnPosition;
    }
}
