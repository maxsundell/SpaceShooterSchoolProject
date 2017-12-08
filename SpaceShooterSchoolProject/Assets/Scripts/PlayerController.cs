using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    public float speedMultiplier = 10f;

    float shipOffsetY = 0.385f;
    float shipOffsetX = 0.5f;

    public float fireDelay = 0.25f;
    float fireTimer = 0f;

    public int hp = 4; 

    public GameObject laser;
    public GameObject parent;
    public GameObject firingPos;

    public GameObject Damage1;
    public GameObject Damage2;
    public GameObject Damage3;

    public GameObject GameOverUI;
    public GameObject GameUI;

    public GameObject PlayerHit;

    private void Start()
    {

        GameUI.SetActive(true);
        GameOverUI.SetActive(false);

        ScoreText.score = 0;

    }


    // Collision Detection
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("BigMeteor"))
        {

            hp -= 2;
            GameObject HitParticle = Instantiate(PlayerHit, collision.transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)), transform);
            Destroy(HitParticle, .25f);

        }


        if(collision.CompareTag("Meteor"))
        {

            hp -= 1;
            GameObject HitParticle = Instantiate(PlayerHit, collision.transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)), transform);
            Destroy(HitParticle, .25f);
        }

        switch (hp)
        {
            case 4:
                Damage1.SetActive(false);
                Damage2.SetActive(false);
                Damage3.SetActive(false);
                break;
            case 3:
                Damage1.SetActive(true);
                Damage2.SetActive(false);
                Damage3.SetActive(false);
                break;
            case 2:
                Damage1.SetActive(false);
                Damage2.SetActive(true);
                Damage3.SetActive(false);
                break;
            case 1:
                Damage1.SetActive(false);
                Damage2.SetActive(false);
                Damage3.SetActive(true);
                break;
        }

        if(hp <= 0)
        {
                        
            GameOverUI.SetActive(true);
            GameUI.SetActive(false);
            Destroy(gameObject);

        }

    }

    void Update()
    {

        

        // Fire Delay Timer
        fireTimer -= Time.deltaTime;

        // Movement
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speedMultiplier, 0, 0);

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
        if(fireTimer <= 0)
        {

            fireTimer = fireDelay;
            Instantiate(laser, firingPos.transform.position, transform.rotation, parent.transform);

        }

    }

}
