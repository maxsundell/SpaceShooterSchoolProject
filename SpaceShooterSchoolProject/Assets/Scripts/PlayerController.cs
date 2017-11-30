using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    public float speedMultiplier = 10f;

    float shipOffsetY = 0.385f;
    float shipOffsetX = 0.5f;

    public float fireDelay = 0.25f;
    float fireTimer = 0f;

    public GameObject laser;
    public GameObject laserShots;
    public GameObject firingPos;

    void Update()
    {

        // Fire Delay Timer
        fireTimer -= Time.deltaTime;

        // Movement
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speedMultiplier, 0, 0);
        transform.Translate(0, Input.GetAxis("Vertical") * Time.deltaTime * speedMultiplier, 0);

        // Screen Border Up
        if(transform.position.y > Camera.main.orthographicSize - shipOffsetY)
        {

            transform.position = new Vector3(transform.position.x, Camera.main.orthographicSize - shipOffsetY, transform.position.z);

        }

        // Scren Border Down
        if(transform.position.y < -Camera.main.orthographicSize + shipOffsetY)
        {

            transform.position = new Vector3(transform.position.x, -Camera.main.orthographicSize + shipOffsetY, transform.position.z);

        }

        // Scren Border Right
        if(transform.position.x > Camera.main.orthographicSize * Camera.main.aspect - shipOffsetX)
        {

            transform.position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect - shipOffsetX, transform.position.y, transform.position.z);

        }

        // Screen Border Left
        if(transform.position.x < -Camera.main.orthographicSize * Camera.main.aspect + shipOffsetX)
        {

            transform.position = new Vector3(-Camera.main.orthographicSize * Camera.main.aspect + shipOffsetX, transform.position.y, transform.position.z);

        }

        // Fire Laser
        if(Input.GetButton("Fire1") && fireTimer <= 0)
        {

            fireTimer = fireDelay;
            Instantiate(laser, firingPos.transform.position, transform.rotation, laserShots.transform);

        }

    }

}
