using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;
    PhotonView photonView;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        photonView = GetComponent<PhotonView>();
    }

    void FixedUpdate()
    {
        // Only move the player object if it's the local users player
        if (photonView.IsMine)
        {
            Move();
        }
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        Vector2 moveVector = new Vector2(horizontal, vertical);

        rb.position += moveVector;
    }
}