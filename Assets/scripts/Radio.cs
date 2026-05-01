using UnityEngine;
 
public class Radio : MonoBehaviour
{
    public AudioSource songAudio;   // audio source on the radio
    public AudioClip[] songs;       // list of songs for the radio
 
    private int currentSong = 0;    // keeps track of what song is playing
    private bool isPlaying = false; // checks if radio is on or off
 
    public void ToggleRadio()
    {
        // if radio is playing, turn it off
        if (isPlaying)
        {
            StopRadio();
        }
        // if radio is off, turn it on
        else
        {
            PlayRadio();
        }
    }
 
    public void PlayRadio()
    {
        if (songAudio == null || songs.Length == 0)
            return;
 
        isPlaying = true;
 
        // set the song and play it
        songAudio.clip = songs[currentSong];
        songAudio.Play();
    }
 
    public void StopRadio()
    {
        isPlaying = false;
 
        // stop the song
        if (songAudio != null)
            songAudio.Stop();
    }
 
    public void SkipSong()
    {
        if (songAudio == null || songs.Length == 0)
            return;
 
        // go to the next song
        currentSong++;
 
        // if we are past the last song, go back to the first song
        if (currentSong >= songs.Length)
        {
            currentSong = 0;
        }
 
        // only play the next song if the radio is already on
        if (isPlaying)
        {
            songAudio.clip = songs[currentSong];
            songAudio.Play();
        }
    }
}