using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    private AudioSource playerAudio;
    public float jumpforce = 10;
    public float gravityModifier;
    public AudioClip jumpSound; 
    public AudioClip crashSound;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public bool isOnGround = true;
    public ParticleSystem dirtParticle;
    public bool gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)    
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            playerAnim.SetTrigger("Jump_trig");
            isOnGround = false; 
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }
     
    private void OnCollisionEnter(Collision collision)
    {
       

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        } else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            gameOver = true;
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }


}
