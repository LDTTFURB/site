using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _pipesGameObject;

    [SerializeField]
    private float _spawnDelay;

    [SerializeField]
    private float _heightRange;

    private float _timer;

    void Start()
    {
        SpawnPipe();
    }

    private void FixedUpdate()
    {
        if (_timer > _spawnDelay)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange), 0);
        GameObject pipe = Instantiate(_pipesGameObject, spawnPos, Quaternion.identity);

        Destroy(pipe, 6f);
    }
}
