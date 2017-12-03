using UnityEngine;

public class MeteorController : MonoBehaviour
{

    int hp = 2;

    public float fallingSpeed = 10f;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("Laser") && transform.position.y <= Camera.main.orthographicSize)
        {        

            hp--;

            if(hp <= 0 && transform.CompareTag("BigMeteor"))
            {

                Destroy(gameObject);

            }

            if (transform.CompareTag("Meteor"))
            {

                Destroy(gameObject);

            }

        }

    }

    void Start()
    {

        Destroy(gameObject, 5f);

    }

    void Update()
    {

        transform.Translate(0, -fallingSpeed * Time.deltaTime, 0, Space.World);

    }

}
