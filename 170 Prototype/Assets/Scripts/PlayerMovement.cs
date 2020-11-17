using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
  public float movementSpeed;
  public Rigidbody2D rb;
  public float jumpForce = 12f;
  public Transform feet;
  public LayerMask groundLayers;
  public Collider2D player;
  public GameObject collectible;

  float mx;

  private void Update(){
    mx = Input.GetAxisRaw("Horizontal");

    if(Input.GetButtonDown("Jump") && IsGrounded()){
      Jump();
    }
    if(DoCollect())
    {
      print("yay");
      collectible.SetActive(false);
    }
  }

  private void OnTriggerEnter2D(Collider2D col){
    // if collide with trap
    if(col.tag == "Trap"){
      // reload the scene
      Scene scene;
      scene = SceneManager.GetActiveScene();
      SceneManager.LoadScene(scene.name);
    }

  }

  private void FixedUpdate() {

    Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

    rb.velocity = movement;
  }

  void Jump(){
    Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

    rb.velocity = movement;
  }

  public bool IsGrounded(){
    Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

    return groundCheck != null;
  }

  public bool DoCollect(){
    return player.IsTouching(collectible.GetComponent<Collider2D>());
  }
}
