using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{

    private float maxHitPoints = 100;
    private float currentHitPoints_UseProperty;

    private Rigidbody rigidbody;


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
    // Use this for initialization
    void Start () 
	{
        CurrentHitPoints = maxHitPoints;
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    public void TakeDamage(float amount)
    {
        CurrentHitPoints -= amount;
    }
}
