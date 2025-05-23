using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CapsuleCollider2D))]
public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    [SerializeField] ColorChange colorChange;
    [SerializeField] UIManager UIManager;
    bool _onYellow;
    bool _onBlue;
    bool _onGreen;
    public void ModifyHealth(int amount)
    {
        health -= amount;
        UIManager.DegreeHeartUI();
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Green"))
        {
            _onGreen = true;
        }
        if (collision.gameObject.CompareTag("Blue"))
        {
            _onBlue = true;
        }
        if (collision.gameObject.CompareTag("Yellow"))
        {
            _onYellow = true;
        }
        if (collision.gameObject.CompareTag("Light"))
        {
            if (_onGreen && colorChange.ColorNumber == 0)
            {
                return;
            }
            if (_onBlue && colorChange.ColorNumber == 1)
            {
                return;
            }
            if (_onYellow && colorChange.ColorNumber == 2)
            {
                return;
            }
            ModifyHealth(1);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Green"))
        {
            _onGreen = false;
        }
        if (collision.gameObject.CompareTag("Blue"))
        {
            _onBlue = false;
        }
        if (collision.gameObject.CompareTag("Yellow"))
        {
            _onYellow = false;
        }
    }
}
