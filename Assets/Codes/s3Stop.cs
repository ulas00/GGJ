using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class s3Stop : MonoBehaviour
{
    public int sayac = 0;
    public GameObject gameobject;
    public TMP_Text storyText;
    public AudioSource audio1;
    public GameObject audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public kirbabü kirsay;

    #region StoryTexts

    private string text1 = "Olaylardan sonra Eşber Bey lokantaları diktatör gibi yönetmektedir. Koray'ı, Milyarder Nedim Bey evlat edinir. Nuray Hanım, Servet Baba ile evlenir.";
    private string text2 = "Delikanlılık çağına gelen Oray babası gibi lokanta açmak adına canla başla çalışır ve lokantacılık mektebinden mezun olur. Eşber Oray'ı işe alır.";
    private string text3 = "Eşber Bey, Oray'ı çok zor şartlarda çalıştırmaktadır. Gene de pes etmeyen Oray'ın lokanta parasını denkleştirmesine bir gün kalmıştır...";
    private string text4 = "SABAH 4.00";
    #endregion

    void Start()
    {
        Time.timeScale = 0f;
        storyText.text = text1;
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            sayac++;
        }
        if(sayac== 1)
        {
            storyText.text = text2;
            audio2.SetActive(true);
        }
        if (sayac == 2)
        {
            storyText.text = text3;
            audio3.Play();
        }
        if (sayac == 3)
        {
            storyText.text = text4;
            audio4.Play();
        }
        if(sayac >=4)
        {
            gameobject.SetActive(false);
            Time.timeScale = 1f;
        }

        if (kirsay.kirsayac >= 4)
        {
            
            gameobject.SetActive(true);
            StartCoroutine(skm());
        }
        
    }
    IEnumerator skm()
    {
        yield return new WaitForSeconds(2.0f);
		kirsay.kirsayac--;
		gameobject.SetActive(false);
	}
}
