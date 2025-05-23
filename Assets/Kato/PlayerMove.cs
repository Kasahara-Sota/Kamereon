using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private float _playerMoveSpeed;
    void Start()
    {
        //Rigidbodyコンポーネントを取得
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 velocity = new Vector2(h, v);
        _rb.velocity = velocity * _playerMoveSpeed;

        if(h != 0 || v != 0)
        {
            transform.up = velocity;
        }//入力があった時進行方向を向く
    }
}
