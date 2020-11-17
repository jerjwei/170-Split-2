using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
  public GameObject trapDoor;

  private void OnTriggerEnter2D(Collider2D col){
    // if collide with Player open trapdoor
    if(col.tag == "Player"){
      trapDoor.SetActive(false);
    }
  }
}
