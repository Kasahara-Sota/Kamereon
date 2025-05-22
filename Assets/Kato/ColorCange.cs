using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCange : MonoBehaviour
{
    [SerializeField] private Color[] _colorArray;
    int _index = 0;
    SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //Spriterendererコンポーネントを取得
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _spriteRenderer.color = _colorArray[(_index += 1) % _colorArray.Length];
        }
        if (Input.GetMouseButtonDown(1))
        {
            _spriteRenderer.color = _colorArray[(_index -= 1) % _colorArray.Length];
        }
    }
}
