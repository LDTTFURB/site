using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _maxWidth;

    private SpriteRenderer _spriteRenderer;

    private Vector2 _startSize;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    void FixedUpdate()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _speed * Time.deltaTime, _spriteRenderer.size.y);

        if (_spriteRenderer.size.x > _maxWidth)
        {
            _spriteRenderer.size = _startSize;
        }
    }
}
