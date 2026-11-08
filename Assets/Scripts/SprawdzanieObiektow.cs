using System.Collections.Generic;
using UnityEngine;

public class SprawdzanieObiektow : MonoBehaviour
{

    public List<GameObject> obiekty = new List<GameObject>();

    void Start()
    {

        SprawdzObiekty();
    }

    public void SprawdzObiekty()
    {
        foreach (GameObject ob in obiekty)
        {
            if (ob == null) continue;

            // Szukamy komponentu 2D (SpriteRenderer lub Collider2D)
            if (ob.GetComponent<SpriteRenderer>() != null || ob.GetComponent<Collider2D>() != null)
            {
                Debug.Log(ob.name + " jest obiektem 2D");
            }
            // Jeśli nie 2D, a posiada MeshRenderer lub Transform w przestrzeni 3D
            else if (ob.GetComponent<MeshRenderer>() != null)
            {
                Debug.Log(ob.name + " jest obiektem 3D");
            }
            else
            {
                Debug.Log(ob.name + " ma inny typ / brak komponentu");
            }
        }
    }
}