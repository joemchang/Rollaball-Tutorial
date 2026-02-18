using UnityEngine;
using UnityEngine.UI;

public class PrefabScript : MonoBehaviour
{
	public GameObject prefab; 
	public Slider scaleSlider;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPrefab(new Vector3(0f,2f,0f));
		SpawnPrefab(new Vector3(2f,2f,0f));
		//
		RandomPrefab();
		RandomPrefab();
		// for loop call 10 times
		for (int i=0;i<10;i++){
			RandomPrefab();
		}
    }

    // Update is called once per frame

    void Update()
    {
       //f (Input.GetKeyDown(KeyCode.Space)){
		//andomPrefab();
		//
		
		//mouse event
		// (Input.GetMouseButtonDown(0)){
			//ndomPrefab();
		//
    }
	public void RandomPrefab(){
		float randomX =Random.Range(-9f, 6);
		float randomZ = Random.Range(-8f, 9f);
		SpawnPrefab(new Vector3(randomX,0f,randomZ));
	}
	
	void SpawnPrefab(Vector3 _spawnPos){
		float scaleVal = scaleSlider.value + 1f;
		// spawn prefab and set position
		GameObject myPrefab = Instantiate(prefab);
		myPrefab.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);
		myPrefab.transform.position = _spawnPos;
	}
}
