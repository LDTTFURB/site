using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private AudioClip m_jumpSfx;

    [SerializeField]
    private float _velocity = 1.5f;

    private Rigidbody2D _rb;

    private Animator _animator;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Jump();
        }

    }

    void Jump()
    {
        _rb.linearVelocity = Vector3.up * _velocity;
        _animator.SetTrigger("Jump");
        SoundManager.instance.PlaySound(m_jumpSfx);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collidable"))
        {
            GameManager.instance.GameOver();
        }
    }
}
