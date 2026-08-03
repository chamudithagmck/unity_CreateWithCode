using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rBody;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;


    public float jumpFroce = 10f;
    public float gravityModifier;


    public bool isOnGround = true;
    public bool gameOver;
    void Start()
    {
        _rBody = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        Physics.gravity = Physics.gravity * gravityModifier;
    }

    private void OnMouseDown()
    {
        isOnGround = false;
        isOnGround = false;
        playerAnim.SetTrigger("Jump_trig");
        dirtParticle.Stop();

        playerAudio.PlayOneShot(jumpSound, 1.0f);


        _rBody.AddForce(Vector3.up * jumpFroce, ForceMode.Impulse);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && gameOver == false)
        {
            _rBody.AddForce(Vector3.up * jumpFroce, ForceMode.Impulse);

            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();

            playerAudio.PlayOneShot(jumpSound, 1.0f);


        }



    }

    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }

        else if (target.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(" Game Over !");
            gameOver = true;

            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);

            explosionParticle.Play();
            dirtParticle.Stop();

            playerAudio.PlayOneShot(crashSound, 3.0f);
        }
    }

}//Class
