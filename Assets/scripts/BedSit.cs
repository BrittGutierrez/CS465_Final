using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class BedSit : MonoBehaviour
{
    public Transform xrOrigin;      // this is the player rig
    public Transform sitPoint;      // where we want the player to sit
 
    public float highlightStrength = 1.3f;
 
    private Renderer[] renderers;
    private Color[][] originalColors;
 
    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        originalColors = new Color[renderers.Length][];
 
        for (int i = 0; i < renderers.Length; i++)
        {
            Material[] mats = renderers[i].materials;
            originalColors[i] = new Color[mats.Length];
 
            for (int j = 0; j < mats.Length; j++)
            {
                if (mats[j].HasProperty("_BaseColor"))
                    originalColors[i][j] = mats[j].color;
            }
        }
    }
 
    public void OnHoverEnter(HoverEnterEventArgs args)
    {
        //highlights the bed when we hover with the controllers
        for (int i = 0; i < renderers.Length; i++)
        {
            Material[] mats = renderers[i].materials;
 
            for (int j = 0; j < mats.Length; j++)
            {
                if (mats[j].HasProperty("_BaseColor"))
                    mats[j].color = originalColors[i][j] * highlightStrength;
            }
        }
    }
 
    public void OnHoverExit(HoverExitEventArgs args)
    {
        //turns highlight off when we stop hovering over bed
        for (int i = 0; i < renderers.Length; i++)
        {
            Material[] mats = renderers[i].materials;
 
            for (int j = 0; j < mats.Length; j++)
            {
                if (mats[j].HasProperty("_BaseColor"))
                    mats[j].color = originalColors[i][j];
            }
        }
    }
 
    public void Sit()
    {
        //moves you to the point on the bed when you press the triggers
        xrOrigin.position = sitPoint.position;
        xrOrigin.rotation = sitPoint.rotation;
    }
}