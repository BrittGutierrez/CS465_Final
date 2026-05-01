using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
 
public class ObjectHighlight : MonoBehaviour

{

    public float highlightStrength = 1.5f; // how bright it gets
 
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
 
    public void HighlightObject(HoverEnterEventArgs args)

    {

        // make the object brighter when pointing at it

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
 
    public void UnhighlightObject(HoverExitEventArgs args)

    {

        // change it back when not pointing at it

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

}
 