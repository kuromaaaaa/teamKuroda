using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    RainSound rs;
    float h;
    // Start is called before the first frame update
    void Start()
    {
        rs = GameObject.Find("RainSoundController").GetComponent<RainSound>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        transform.position = new Vector2(transform.position.x + h * 0.1f, transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector2(transform.position.x , transform.position.y + 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Shelter")
        {
            rs.isUnderShelter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Shelter")
        {
            rs.isUnderShelter = false;
        }
    }
}
