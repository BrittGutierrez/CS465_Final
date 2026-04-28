using UnityEngine;

using UnityEngine.Video;
 
public class TV : MonoBehaviour

{

    public VideoPlayer videoPlayer;     // this is the video on the screen

    public Renderer screenRenderer;     // the actual TV screen (the quad)

    public AudioSource startupSound;    // the startup sound for the TV
 
    public Material offMaterial;        // black screen when TV is off

    public Material videoMaterial;      // the material that shows the video
 
    public float delayBeforeVideo = 1f; // how long it waits before turning on
 
    public void TurnOnTV()

    {

        // play the startup sound when you press the button

        if (startupSound != null)

            startupSound.Play();
 
        // reset the video and make the screen black first

        videoPlayer.Stop();

        screenRenderer.material = offMaterial;
 
        // wait a second, then start the video

        Invoke(nameof(PlayVideo), delayBeforeVideo);

    }
 
    void PlayVideo()

    {

        // switch the screen back to the video and start playing

        screenRenderer.material = videoMaterial;

        videoPlayer.Play();

    }

}
 