    using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;

    public float Jump = 20f; 
    public float gravityModifier;

    public bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       playerRb = GetComponent<Rigidbody>();
       Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
           playerRb.AddForce(Vector3.up * Jump , ForceMode.Impulse);
           isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
