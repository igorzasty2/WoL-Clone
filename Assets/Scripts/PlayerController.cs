using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl Instance { get; private set; }
    public float speed;
    Rigidbody2D playerbody;
    private Vector2 lastDirection;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        playerbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical);
        if (movement.y != 0 || movement.x != 0)
        {
            lastDirection = movement;
        }
        playerbody.velocity = movement * speed;

        if (Input.GetButtonDown("AttackBasic"))
        {
            Attack();
        }
    }
    void Attack()
    {
        print("attacked" + lastDirection);
    }
    public Transform GetPlayerTransform()
    {
        return transform;
    }
}