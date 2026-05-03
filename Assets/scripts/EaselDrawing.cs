using UnityEngine;
 
public class EaselDrawing : MonoBehaviour

{

    public Renderer canvasRenderer; // the canvas on the easel

    public Material[] drawings;     // blank canvas and drawings
 
    private int currentDrawing = 0; //holds canvas materials (blank canvas and the drawings)
 
    void Start()

    {

        if (canvasRenderer == null)

            canvasRenderer = GetComponent<Renderer>();
 
        if (canvasRenderer != null)

            Debug.Log("Canvas Renderer found: " + canvasRenderer.name);

        else

            Debug.Log("Canvas Renderer is missing");
        //how many drawings were added to inspector 
        if (drawings != null)

            Debug.Log("Number of drawings: " + drawings.Length);

    }
 
    public void ChangeDrawing()

    {
        //makes sure interaction happens
        Debug.Log("Easel was pressed");
 
        if (canvasRenderer == null)

        {

            Debug.Log("Canvas Renderer is missing");

            return; // stops so script doesnt break

        }
 
        if (drawings == null || drawings.Length == 0)

        {

            Debug.Log("No drawings added");

            return;

        }
         //moves to the next drawing
        currentDrawing++;
         //loops back to the first drawing after going through them all
        if (currentDrawing >= drawings.Length)

        {

            currentDrawing = 0;

        }
         //changes material to current drawling
        canvasRenderer.sharedMaterial = drawings[currentDrawing];
         //we can check which drawing it changed to in console
        Debug.Log("Changed easel drawing to: " + drawings[currentDrawing].name);

    }

}
 