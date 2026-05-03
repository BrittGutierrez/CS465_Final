using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
 
public class ObjectHighlight : MonoBehaviour

{

    public float highlightStrength = 1.5f; // how bright the object gets
 
    private Renderer[] renderers; //stores renderers on object and children

    private Color[][] originalColors; // saves original colors to change back to
 
    void Start()

    {
        //gets renderers on object and child objs 
        renderers = GetComponentsInChildren<Renderer>();
        //space to store colors
        originalColors = new Color[renderers.Length][];
 //loops every renderer on obj
        for (int i = 0; i < renderers.Length; i++)

        {
            //gets materials on renderer
            Material[] mats = renderers[i].materials;
            //makes space for material color
            originalColors[i] = new Color[mats.Length];
 //loops material color
            for (int j = 0; j < mats.Length; j++)

            {
                //only save color if material has base color prop
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
            //gets materials for renderer
            Material[] mats = renderers[i].materials;
 //loop material and brighten it 
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
 //resets to original color
            for (int j = 0; j < mats.Length; j++)

            {
                //only if it has base color
                if (mats[j].HasProperty("_BaseColor"))

                    mats[j].color = originalColors[i][j];

            }

        }

    }

}
 