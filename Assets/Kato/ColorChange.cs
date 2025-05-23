using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Color[] _colorArray;
    private PlayerHealth _playerHealth;
    int _index = 0;
    public int ColorNumber => _index;
    SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //Spriterendererコンポーネントを取得
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = _colorArray[0];
        _playerHealth = GetComponent<PlayerHealth>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _index = (_index + 1) % _colorArray.Length;
            _spriteRenderer.color = _colorArray[_index];
            AudioManager.Instance.PlaySE("ColorChange");
            _playerHealth.CheckLight();
        }
        if (Input.GetMouseButtonDown(1))
        {
            _index = (_index - 1 + _colorArray.Length) % _colorArray.Length;
            _spriteRenderer.color = _colorArray[_index];
            AudioManager.Instance.PlaySE("ColorChange");
            _playerHealth.CheckLight();
        }
    }
}
