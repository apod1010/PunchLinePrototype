using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth = 100f;

    GameObject critButton;

    public Slider healthSlider;

    [SerializeField]
    private int damageTaken = 20;

    private void Start()
    {
        currentHealth = maxHealth;

        critButton = GameObject.Find("CritButton");

        critButton.GetComponent<Button>().interactable = false;
    }

    public void OnTargetTap()
    {
        AdjustCurrentHealth(-damageTaken);
        healthSlider.value = currentHealth;
    }

    public void AdjustCurrentHealth(int adj)
    {
        currentHealth += adj;

        if (currentHealth < 0)
            currentHealth = 0;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;

        if (currentHealth < 1)
        {
            SceneManager.LoadScene("End");
        }
    }
}
