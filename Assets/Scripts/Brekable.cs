using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brekable : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timeToBreak = 2f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var breakablePiece in breakablePieces)
        {
            breakablePiece.SetActive(false);
        }
    }

    public void Break()
    {
        timer += Time.deltaTime;

        if (timer >= timeToBreak)
        {
            foreach (var breakablePiece in breakablePieces)
            {
                breakablePiece.SetActive(true);
                breakablePiece.transform.parent = null;
            }
        
            gameObject.SetActive(false);
        }

    }
}
