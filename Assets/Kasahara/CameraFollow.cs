using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] Vector2 _size;

    private Transform CameraTransform;
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 1, 0);
        Gizmos.DrawWireCube(transform.position, _size);
    }
    void Start()
    {
        CameraTransform = Camera.main.transform;
    }
    void LateUpdate()
    {
        Vector3 pos = _target.position;
        pos.z = -10;
        if (_target.position.x < transform.position.x - _size.x)
        {
            pos.x = transform.position.x - _size.x;
        }
        else if(_target.position.x > transform.position.x + _size.x)
        {
            pos.x = transform.position.x + _size.x;
        }
        if (_target.position.y < transform.position.y - _size.y)
        {
            pos.y = transform.position.y - _size.y;
        }
        else if (_target.position.y > transform.position.y + _size.y)
        {
            pos.y = transform.position.y + _size.y;
        }
        CameraTransform.position = pos;
    }
}
