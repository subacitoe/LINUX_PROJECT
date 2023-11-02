using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float speed;
    [SerializeField] private float speedOrigin;
    [SerializeField] private float speedDiagonal;

    private SpriteRenderer spriteRenderer;
    private Animator _ani;
    float Xvec, Yvec;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        _ani = GetComponent<Animator>();
    }

    void Turn()
    {
        float horizontalInput = Xvec;
        if (horizontalInput > 0)
        {
            // Flip the sprite horizontally
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            // If you want to flip the sprite when moving left, uncomment the following line
            spriteRenderer.flipX = true;
        }
    }
    void FixDiagonal()
    {
        if(Input.GetAxisRaw("Horizontal")!=0 && Input.GetAxisRaw("Vertical")!=0){
            speed = speedDiagonal;
        }
        else{
            speed = speedOrigin; 
        }
    }
    void FixAnimation()
    {
        _ani.SetBool("isRunning", Xvec != 0 || Yvec != 0);
    }
    // Update is called once per frame
    void Update()
    {
        Xvec = Input.GetAxisRaw("Horizontal") * speed;
        Yvec = Input.GetAxisRaw("Vertical") * speed;
        rb.velocity = new Vector2(Xvec, Yvec);
        Turn();
        FixDiagonal();
        FixAnimation();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PC"))
        {
            PC pc = collision.GetComponent<PC>();
            if (pc != null)
            {
                pc.ShowSetting();
            }
        }
    }


}
