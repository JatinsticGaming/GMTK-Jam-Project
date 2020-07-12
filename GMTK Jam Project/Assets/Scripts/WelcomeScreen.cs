using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(AudioSource))]
public class WelcomeScreen : MonoBehaviour
{
    public Button StartButton;
    public Button ExitButton;
    public AudioSource Music;
    public AudioSource ButtonPressSource;
    public Image BlackoutImage;
    public float BlackoutSpeed = 3;
    public float MusicFadeOutSpeed = 1;
    public float DelayedExitSpeed = 1;
    // Start is called before the first frame update
    void Awake()
    {
        BlackoutImage.enabled = false;
        StartButton.onClick.AddListener(PlaySound);
        ExitButton.onClick.AddListener(PlaySound);
        StartButton.onClick.AddListener(SwapToNextLevel);
        ExitButton.onClick.AddListener(ExitApplication);
    }

    public void PlaySound()
    {
        ButtonPressSource.Play();
    }

    IEnumerator DelayedExit(float time)
    {
        yield return new WaitForSeconds(time);
        Application.Quit();
    }

    IEnumerator VolumeDown(float speed)
    {
        for (; Music.volume >= 0; Music.volume -= speed * Time.deltaTime)
        {
            yield return null;
        }
    }

    IEnumerator Blackout(float speed)
    {
        for (; BlackoutImage.color.a < 1; BlackoutImage.color = new Color(0, 0, 0, BlackoutImage.color.a + speed * Time.deltaTime))
        {
            yield return null;
        }
    }
    public void ExitApplication()
    {
        Debug.Log("Application Quit!");
        if (Music != null)
        {
            StartCoroutine(VolumeDown(MusicFadeOutSpeed));
        }
        if (BlackoutImage != null)
        {
            BlackoutImage.enabled = true;
            StartCoroutine(Blackout(BlackoutSpeed));
        }
        StartCoroutine(DelayedExit(DelayedExitSpeed));
    }

    public void SwapToNextLevel()
    {
        Debug.Log("LevelSwap!");
    }
}
