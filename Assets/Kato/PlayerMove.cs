using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform _tr;
    public Rigidbody2D _rb;


    [SerializeField]
    private Rigidbody2D _rigidbody2D;

    [SerializeField]
    private float PlayerMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKey(KeyCode.W);
        
    }
}
