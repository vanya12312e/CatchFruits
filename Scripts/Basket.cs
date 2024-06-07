using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class Basket : MonoBehaviour
{
    

   [SerializeField] private float speed = 5f;  
    private const float minX = -8f;   
    private const float maxX = 8f;    
    private Vector3 targetPosition;


    private void Awake() => Cursor.visible = true;




    void Update()
    {
        
        Cursor.visible = false;
       
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

       
        targetPosition = new Vector3(mousePosition.x, transform.position.y, transform.position.z);

        
        targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);

     
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

    }


}
