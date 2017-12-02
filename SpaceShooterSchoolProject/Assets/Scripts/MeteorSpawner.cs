using UnityEngine;

public class MeteorSpawner : MonoBehaviour 
{

    public float spawnDelay = 1f;
    float spawnTimer = 0f;

    public GameObject MeteorB1;
    public GameObject MeteorB2;
    public GameObject MeteorB3;
    public GameObject MeteorB4;

    public GameObject MeteorM1;
    public GameObject MeteorM2;

    public GameObject MeteorS1;
    public GameObject MeteorS2;
    public GameObject MeteorS3;
    public GameObject MeteorS4;

    void Update()
    {

        spawnTimer = -Time.deltaTime;

        if(spawnTimer <= 0)
        {
        }

    }

}
