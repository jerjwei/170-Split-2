using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
  public int collect_num = 0;
  public GameObject Canvas;
  public Rigidbody2D rb;
  void OnTriggerEnter2D(Collider2D other){

    if (other.gameObject.layer == 9){
        collect_num += 1;
      }
    if (collect_num == 3){
        Canvas.SetActive(true);
        Destroy (other.gameObject);
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
      }
  }
}
