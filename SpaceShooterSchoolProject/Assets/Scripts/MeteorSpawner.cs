using UnityEngine;

public class MeteorSpawner : MonoBehaviour 
{

    public float spawnDelay = 1f;
    float spawnTimer = 0f;

    float cameraWidth;
    float spawnHeight;

    public GameObject meteorB1;
    public GameObject meteorB2;
    public GameObject meteorB3;
    public GameObject meteorB4;

    public GameObject meteorM1;
    public GameObject meteorM2;

    public GameObject meteorS1;
    public GameObject meteorS2;
    public GameObject meteorS3;
    public GameObject meteorS4;

    GameObject[] meteors;

    private void Start()
    {

        cameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
        spawnHeight = Camera.main.orthographicSize * 2 + 5;

        meteors = new GameObject[12];

        meteors[0] = meteorB1;
        meteors[1] = meteorB2;
        meteors[2] = meteorB3;
        meteors[3] = meteorB4;

        meteors[4] = meteorM1;
        meteors[5] = meteorM2;
        meteors[6] = meteorM1;
        meteors[7] = meteorM2;

        meteors[8] = meteorS1;
        meteors[9] = meteorS2;
        meteors[10] = meteorS3;
        meteors[11] = meteorS4;

    }

    void Update()
    {

        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0)
        {

            spawnTimer = spawnDelay;

            Vector3 spawnPos = new Vector3(Random.Range(-cameraWidth, cameraWidth), spawnHeight, 0);

            Instantiate(meteors[Random.Range(0, meteors.Length)], spawnPos, Quaternion.Euler(0, 0, Random.Range(0, 360)), transform);

        }

    }

}
