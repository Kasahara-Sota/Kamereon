using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rb;
    private AudioSource _audioSource;
    [SerializeField] private float _playerMoveSpeed;
    void Start()
    {
        //Rigidbodyコンポーネントを取得
        _rb = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
        _audioSource.loop = true;
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
            if(!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }//ついでに歩く音を鳴らす
        }//入力があった時進行方向を向く
        else
        {
            _audioSource.Stop();
        }
    }
}
