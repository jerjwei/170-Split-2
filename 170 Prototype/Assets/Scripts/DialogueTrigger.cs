using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
  public int collect_num = 0;
  public GameObject dialogueBox;
  private void OnTriggerEnter2D(Collider2D col){

    if(col.gameObject.layer == 9){
        collect_num += 1;
      }
    if (collect_num >= 3){
        dialogueBox.SetActive(true);
      }
  }
}
