using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField]
    private float _playerMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyコンポーネントを取得
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 velocity = new Vector2(h, v);
        _rb.velocity = velocity * _playerMoveSpeed;

        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.AngleAxis(90.0f, new Vector3(0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.AngleAxis(90.0f, new Vector3(0, 0, 1));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.AngleAxis(90.0f, new Vector3(0, 0, -1));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.AngleAxis(180.0f, new Vector3(0, 0, 1));
        }
    }
}
