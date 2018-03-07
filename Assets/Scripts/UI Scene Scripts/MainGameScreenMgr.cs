using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameScreenMgr : MonoBehaviour 
{

    private float maxHitPoints = 100;
    private float currentHitPoints_UseProperty;

    public float CurrentHitPoints
    {
        get
        {
            return currentHitPoints_UseProperty;
        }

        private set
        {
            currentHitPoints_UseProperty = value;

            if (currentHitPoints_UseProperty < 0)
                currentHitPoints_UseProperty = 0;

            if (currentHitPoints_UseProperty > maxHitPoints)
                currentHitPoints_UseProperty = maxHitPoints;
        }
    }

    public float CurrentHitPointsAsPercentage
    {
        get
        {
            return CurrentHitPoints / maxHitPoints;
        }
    }

    void Start()
    {
        CurrentHitPoints = maxHitPoints;
    }

    public void BackArrowTap()
    {
        SceneManager.LoadScene("Title");
    }

    public void OnHit(float amount)
    {
        CurrentHitPoints -= amount;
    }
}
