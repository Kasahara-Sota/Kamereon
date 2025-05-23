using UnityEngine;

public class Respawn : MonoBehaviour
{
    //‰ŠúˆÊ’u‚ğRespawnPosition‚Æ‚µ‚Äİ’è
    Vector2 RespawnPosition = new Vector2();
    void Start()
    {
        RespawnPosition = transform.localPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Light‚ÉÚG‚µ‚½‚ç‰ŠúˆÊ’u‚ÉˆÚ“®
        if (collision.gameObject.CompareTag("Light"))
        {
            transform.localPosition = RespawnPosition;
        }
    }
}
