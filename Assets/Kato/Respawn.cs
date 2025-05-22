using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Transform _tr;
    //‰ŠúˆÊ’u‚ğRespawnPosition‚Æ‚µ‚Äİ’è
    Vector2 RespawnPosition = new Vector2();
    // Start is called before the first frame update
    void Start()
    {

        _tr = transform;

        RespawnPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Light‚ÉÚG‚µ‚½‚ç‰ŠúˆÊ’u‚ÉˆÚ“®
        if(collision.gameObject.CompareTag("Light"))
        {
            _tr.localPosition = RespawnPosition;
        }
    }
}
