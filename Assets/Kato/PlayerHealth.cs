using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CapsuleCollider2D))]
public class PlayerHealth : MonoBehaviour
{
    public int Health = 3;
    [SerializeField] ColorChange _colorChange;
    [SerializeField] Respawn _respawn;
    [SerializeField] UIManager UIManager;
    bool _onYellow;
    bool _onBlue;
    bool _onGreen;
    bool _onLight;
    /// <summary>
    /// health�����炷����
    /// </summary>
    /// <param name="amount"></param>
    public void ModifyHealth(int amount)
    {
        Health -= amount;
        UIManager.DegreeHeartUI();
        if (Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void CheckLight()
    {
        if (!_onLight)
        {
            return;
        }
        if (_onGreen && _colorChange.ColorNumber == 0)
        {
            return;
        }
        if (_onBlue && _colorChange.ColorNumber == 1)
        {
            return;
        }
        if (_onYellow && _colorChange.ColorNumber == 2)
        {
            return;
        }
        ModifyHealth(1);
        _respawn.PlayerRespawn();
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
            _onLight = true;
            CheckLight();
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
        if(collision.gameObject.CompareTag("Light"))
        {
            _onLight = false;
        }
    }
}
