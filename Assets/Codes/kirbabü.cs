using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kirbabü : MonoBehaviour
{
	public GameObject gameobject;
	public TMP_Text storyText;
	public AudioSource audio7;
    public float kirsayac;
	public esbergorev esbo;
	private void Update()
	{
		if (kirsayac == 4)
		{
			storyText.text = "18 SAAT SONRA";
            gameobject.SetActive(true);
			audio7.Play();
            esbo.gorev1yapildi = true;
			esbo.esbergorev2.SetActive(true);
            Destroy(gameObject);
		}
	}
}
