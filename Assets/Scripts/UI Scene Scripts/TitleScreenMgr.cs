using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenMgr : MonoBehaviour
{
     public void FightButtonTap()
    {
        SceneManager.LoadScene("Main");
    }

    public void CreatorsButonTap()
    {
        SceneManager.LoadScene("Credits");
    }
}
