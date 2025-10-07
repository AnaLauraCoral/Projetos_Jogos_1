using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Vector2 posicaoinicial;
    public GameManager GameManager;
    public Animator anim;
    private Rigidbody2D rigd;
    private float speed = 6;
    public float jumpForce = 5f;
    private bool isground;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        anim = GetComponent<Animator>();
        rigd = GetComponent<Rigidbody2D>();
        posicaoinicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    public void Reiniciaposi()
    {
        transform.position = posicaoinicial;
    
    }

    void Move()
    {
        float teclas = Input.GetAxis("Horizontal");
        rigd.linearVelocity = new Vector2(teclas * speed, rigd.linearVelocity.y);

        if (teclas > 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0,0);
            anim.SetInteger("transition", 1);
        }
        if(teclas < 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 180);
            anim.SetInteger("transition", 1);
        }
        if (teclas == 0 && isground == true)
        {
            anim.SetInteger("transition", 0);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isground == true)
        {

            rigd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetInteger("transition", 2);
            isground = false;
        }
    }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "tagGround")
            {
                Debug.Log("esta no chao");
                isground = true;
                
            }
        }
    }




