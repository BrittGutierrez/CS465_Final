using UnityEngine;
 
public class EaselDrawing : MonoBehaviour

{

    public Renderer canvasRenderer; // the canvas on the easel

    public Material[] drawings;     // blank canvas and drawings
 
    private int currentDrawing = 0;
 
    void Start()

    {

        if (canvasRenderer == null)

            canvasRenderer = GetComponent<Renderer>();
 
        if (canvasRenderer != null)

            Debug.Log("Canvas Renderer found: " + canvasRenderer.name);

        else

            Debug.Log("Canvas Renderer is missing");
 
        if (drawings != null)

            Debug.Log("Number of drawings: " + drawings.Length);

    }
 
    public void ChangeDrawing()

    {

        Debug.Log("Easel was pressed");
 
        if (canvasRenderer == null)

        {

            Debug.Log("Canvas Renderer is missing");

            return;

        }
 
        if (drawings == null || drawings.Length == 0)

        {

            Debug.Log("No drawings added");

            return;

        }
 
        currentDrawing++;
 
        if (currentDrawing >= drawings.Length)

        {

            currentDrawing = 0;

        }
 
        canvasRenderer.sharedMaterial = drawings[currentDrawing];
 
        Debug.Log("Changed easel drawing to: " + drawings[currentDrawing].name);

    }

}
 