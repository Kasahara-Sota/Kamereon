using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Transform _tr;
    //�����ʒu��RespawnPosition�Ƃ��Đݒ�
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
        //Light�ɐڐG�����珉���ʒu�Ɉړ�
        if(collision.gameObject.CompareTag("Light"))
        {
            _tr.localPosition = RespawnPosition;
        }
    }
}
