using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Script : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    PlayerHealth joueur;

    private void Start() {
        // localiser notre image
        HealthBar = GetComponent<Image>();
        joueur = FindObjectOfType<PlayerHealth>();
    }
    private void Update() {
        CurrentHealth = joueur.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
        if (Input.GetKeyDown(KeyCode.Space)) // si on appuis sur la barre espace, on prend des DMG.
		{
			TakeDamage(20); // on prend 20 point de DMG car on a regler la valeur a 20.
		}
    }

    // on dit que l'orsque qu'on prend des DMG, notre vie baisse par rapport au DMG subit.
	void TakeDamage(int damage) 
	{
		CurrentHealth -= damage;

	}
		
}
