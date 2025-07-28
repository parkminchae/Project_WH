using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float player_speed;
    public bool if_player_run;
    public float player_run_rate;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if_player_run = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKey(KeyCode.LeftShift))
        {
           moveVelocity = moveInput.normalized * player_speed * player_run_rate;
        }
        else
        {
            moveVelocity = moveInput.normalized * player_speed;
        }
        
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
