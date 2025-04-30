using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.65f;

    void FixedUpdate()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.UpdateScore();
        }
    }
}
