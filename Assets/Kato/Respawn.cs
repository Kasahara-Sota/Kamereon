using UnityEngine;

public class Respawn : MonoBehaviour
{
    //�����ʒu��RespawnPosition�Ƃ��Đݒ�
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
