using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenMgr : MonoBehaviour {

	public void FightAgainButtonClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void ReturnButtonClick()
    {
        SceneManager.LoadScene("Title");
    }
}
