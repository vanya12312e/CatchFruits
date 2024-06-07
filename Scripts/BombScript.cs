using UnityEngine;

public class BombScript : MonoBehaviour
{
    public TextManager textManager;
    private void Awake()
    {
        textManager = FindObjectOfType<TextManager>();
    }

    private void Update()
    {
        transform.Translate(Vector2.down * 10 * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Basket"))
        {
            Destroy(gameObject);
            textManager.LoseLife();

        }
    }
}
