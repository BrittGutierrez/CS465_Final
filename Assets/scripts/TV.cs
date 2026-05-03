using UnityEngine;

using UnityEngine.Video;
 
public class TV : MonoBehaviour

{

    public VideoPlayer videoPlayer;     // video that plays on the tv screen

    public Renderer screenRenderer;     // the tv screen

    public AudioSource startupSound;    // sound when the tv turns on
 
    public Material offMaterial;        // black screen

    public Material videoMaterial;      // screen with the video
 
    public float delayBeforeVideo = 1f; // wait before the video starts
 
    private bool isOn = false;          // checks if the tv is on or off
 
    public void ToggleTV()

    {

        // if the tv is already on then turn it off

        if (isOn)

        {

            TurnOffTV();

        }

        // if the tv is off then turn it on

        else

        {

            TurnOnTV();

        }

    }
 
    public void TurnOnTV()

    {

        isOn = true;
 
        // play the tv sound
 
        if (startupSound != null)

            startupSound.Play();
 
        // stop the video first so it starts over

        if (videoPlayer != null)

            videoPlayer.Stop();
 
        // make the screen black first

        if (screenRenderer != null)

            screenRenderer.material = offMaterial;
 
        // wait a second then play the video

        Invoke(nameof(PlayVideo), delayBeforeVideo);

    }
 
    public void TurnOffTV()

    {

        isOn = false;
 
        // stop the delayed video from turning on

        CancelInvoke(nameof(PlayVideo));
 
        // stop the video

        if (videoPlayer != null)

            videoPlayer.Stop();
 
        // make the screen black

        if (screenRenderer != null)

            screenRenderer.material = offMaterial;

    }
 
    void PlayVideo()

    {

        // if the tv was turned off, don't play the video

        if (!isOn)

            return;
 
        // show the video on the screen

        if (screenRenderer != null)

            screenRenderer.material = videoMaterial;
 
        // play the video

        if (videoPlayer != null)

            videoPlayer.Play();

    }

}
 