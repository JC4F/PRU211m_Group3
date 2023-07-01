using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleOpenPauseDialog : MonoBehaviour
{
  private DialogManager dialogManager;

  void Start()
  {
    dialogManager = GameObject.FindGameObjectWithTag("DialogManager").GetComponent<DialogManager>();
  }
  public void OnMouseDown()
  {
    dialogManager.handlOpenPauseDialog();
  }
}
