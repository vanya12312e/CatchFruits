using UnityEngine;
using UnityEngine.UI;

public class MovePrefab : MonoBehaviour
{
    public float speed = 10;
    [SerializeField] private Text errorText;
    public int errors = 5;
    private void Update() {

        transform.Translate(Vector2.down * 10 * Time.deltaTime);
        if(transform.position.y == -7)
        {
            Destroy(gameObject);
        }
    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Basket")) Destroy(gameObject);
       
    }
}



