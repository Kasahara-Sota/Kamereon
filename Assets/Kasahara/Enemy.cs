using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform _light;
    [SerializeField] Sprite FrontSprite;
    [SerializeField] Sprite BackSprite;
    [SerializeField] Sprite LeftSprite;
    [SerializeField] EnemyAction[] _enemyActions;
    SpriteRenderer _spriteRenderer;
    [System.Serializable]
    struct EnemyAction
    {
        public ActionType Type;
        public Direction Dir;
        public float Duration;
    }
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(e());
    }
    IEnumerator e()
    {
        while (true)
        {
            foreach (EnemyAction action in _enemyActions)
            {
                switch (action.Type)
                {
                    case ActionType.Rotate:
                        switch (action.Dir)
                        {
                            case Direction.Left: LookLeft(); break;
                            case Direction.Right: LookRight(); break;
                            case Direction.Up: LookBack(); break;
                            case Direction.Down: LookFront(); break;
                        }; 
                        break;
                    case ActionType.Move:
                        switch (action.Dir)
                        {
                            case Direction.Left: MoveLeft(action.Duration); break;
                            case Direction.Right: MoveRight(action.Duration); break;
                            case Direction.Up: MoveBack(action.Duration); break;
                            case Direction.Down: MoveFront(action.Duration); break;
                        };
                        break;
                    default:; break;
                }
                float timer = 0;
                while (timer < action.Duration)
                {
                    yield return null;
                    timer += Time.deltaTime;
                }
            }
        }
    }
    void LookLeft()
    {
        _light.transform.eulerAngles = new Vector3(0, 0, -90);
        _spriteRenderer.sprite = LeftSprite;
        _spriteRenderer.flipX = false;
    }
    void LookRight()
    {
        _light.transform.eulerAngles = new Vector3(0, 0, 90);
        _spriteRenderer.sprite = LeftSprite;
        _spriteRenderer.flipX = true;
    }
    void LookBack()
    {
        _light.transform.eulerAngles = new Vector3(0, 0, 180);
        _spriteRenderer.sprite = BackSprite;
    }
    void LookFront()
    {
        _light.transform.eulerAngles = Vector3.zero;
        _spriteRenderer.sprite = FrontSprite;
    }
    void MoveLeft(float duration)
    {
        float x = transform.position.x - 1;
        LookLeft();
        transform.DOMoveX(x,duration).SetEase(Ease.Linear);
    }
    void MoveRight(float duration)
    {
        float x = transform.position.x + 1;
        LookRight();
        transform.DOMoveX(x, duration).SetEase(Ease.Linear);
    }
    void MoveBack(float duration)
    {
        float y = transform.position.y + 1;
        LookBack();
        transform.DOMoveY(y, duration).SetEase(Ease.Linear);
    }
    void MoveFront(float duration)
    {
        float y = transform.position.y - 1;
        LookFront();
        transform.DOMoveY(y, duration).SetEase(Ease.Linear);
    }
    private enum Direction
    {
        Left,
        Right,
        Up,
        Down,
    }
    private enum ActionType
    {
        Wait,
        Move,
        Rotate,
    }
}
