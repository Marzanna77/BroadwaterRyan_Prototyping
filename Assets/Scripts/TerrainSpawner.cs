using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour {

    public GameObject TerrainPrefab;

    public float SpawnDelay;

    public List<GameObject> Rocks = new List<GameObject>();
    

	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnTerrain());

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    IEnumerator SpawnTerrain()
    {
        //Debug.Log("entered spawn wall"); //sending message to console
        Instantiate(Rocks[Random.Range(0, Rocks.Count)], transform.position, Quaternion.identity); //will spawn shit at spawner loaction

        yield return new WaitForSeconds(SpawnDelay);

        StartCoroutine(SpawnTerrain());

       // Debug.Log("exited spawn wall"); //testing to make sure coroutine works
    }



}
