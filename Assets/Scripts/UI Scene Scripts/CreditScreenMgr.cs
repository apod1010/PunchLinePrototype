using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScreenMgr : MonoBehaviour
{
  public void BackButtonTap()
    {
        SceneManager.LoadScene("Title");
    }
}
