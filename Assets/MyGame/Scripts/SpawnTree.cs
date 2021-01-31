using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{

    public GameObject TreePrefab;
    public GameObject parentDamageSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;

    void Start()
    {
        TreeSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            TreeSpawner();
        }
    }

    private void TreeSpawner()
    {
        var clones = Instantiate(TreePrefab);
        clones.GetComponent<Transform>().SetParent(parentDamageSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
    }
}