using UnityEngine;

public class Respawn : MonoBehaviour
{
    //�����ʒu��RespawnPosition�Ƃ��Đݒ�
    Vector2 RespawnPosition = new Vector2();
    void Start()
    {
        RespawnPosition = transform.localPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Light�ɐڐG�����珉���ʒu�Ɉړ�
        if (collision.gameObject.CompareTag("Light"))
        {
            transform.localPosition = RespawnPosition;
        }
    }
}
