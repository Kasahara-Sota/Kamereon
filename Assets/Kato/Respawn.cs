using UnityEngine;

public class Respawn : MonoBehaviour
{
    //‰ŠúˆÊ’u‚ğRespawnPosition‚Æ‚µ‚Äİ’è
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
