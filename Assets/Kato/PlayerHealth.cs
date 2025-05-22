using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    [SerializeField] ColorChange colorChange;
    bool _onRed;
    bool _onYellow;
    bool _onPink;
    bool _onBlue;
    bool _onWhite;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ModifyHealth(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Red"))
        {
            _onRed = true;
        }
        if (collision.gameObject.CompareTag("Red"))
        {
            _onYellow = true;
        }
        if (collision.gameObject.CompareTag("Red"))
        {
            _onPink = true;
        }
        if (collision.gameObject.CompareTag("Red"))
        {
            _onBlue = true;
        }
        if (collision.gameObject.CompareTag("Red"))
        {
            _onWhite = true;
        }
        if (collision.gameObject.CompareTag("Light"))
        {
            if (_onRed && colorChange.ColorNumber == 0)
            {

            }
            if (_onYellow && colorChange.ColorNumber == 1)
            {

            }
            if (_onPink && colorChange.ColorNumber == 2)
            {

            }
            if (_onBlue && colorChange.ColorNumber == 3)
            {

            }
            if (_onWhite && colorChange.ColorNumber == 4)
            {

            }
            ModifyHealth(1);
        }
    }
}
