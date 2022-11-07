using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField] GameObject circlePrefab = null;
    [SerializeField] float maxRandomRange = 5f;
    [SerializeField] float minRandomRange = 2f;
    [SerializeField] float spawnRate = 1f;
    [SerializeField] Transform parentToSpawn = null;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    private void Spawn()
    {
        var randomPosition = Random.insideUnitCircle * maxRandomRange;
        if (randomPosition.sqrMagnitude < minRandomRange) { return; }

        var circle = Instantiate(circlePrefab, randomPosition, Quaternion.identity);
        circle.transform.SetParent(parentToSpawn);
    }
}
