using UnityEngine;

public class Inmigo_Slime : MonoBehaviour
{
    public GameManager GameManager;
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Perdervida(1);
        }
    }

}
