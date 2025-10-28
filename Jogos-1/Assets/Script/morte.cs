using UnityEngine;

public class morte : MonoBehaviour

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
