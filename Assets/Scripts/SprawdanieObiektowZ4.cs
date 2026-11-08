using System.Collections.Generic;
using UnityEngine;

public class SprawdzanieObiektowZ4 : MonoBehaviour
{
    // Zbiór GameObjectów w Inspektorze
    public List<GameObject> obiekty = new List<GameObject>();

    void Start()
    {
        SprawdzObiektow();
    }

    // 1. Główna funkcja sprawdzająca zbiór (z Zadania 3)
    public void SprawdzObiektow()
    {
        foreach (GameObject ob in obiekty)
        {
            if (ob == null) continue;

            // Sprawdzamy czy to obiekt 2D (posiada SpriteRenderer)
            SpriteRenderer spriteComp = ob.GetComponent<SpriteRenderer>();
            if (spriteComp != null)
            {
                Debug.Log(ob.name + " jest obiektem 2D");
                // Wywołanie drugiej funkcji dla obiektu 2D
                DebugujSprite(spriteComp);
            }
            // Sprawdzamy czy to obiekt 3D (np. posiada MeshRenderer lub zwykły Transform 3D)
            else
            {
                Transform transformComp = ob.GetComponent<Transform>();
                if (transformComp != null && ob.GetComponent<MeshRenderer>() != null)
                {
                    Debug.Log(ob.name + " jest obiektem 3D");
                    // Wywołanie trzeciej funkcji dla obiektu 3D
                    DebugujTransform(transformComp);
                }
            }
        }
    }

    // 2. Druga funkcja: przyjmuje klasę SpriteRenderer i ją debuguje
    public void DebugujSprite(SpriteRenderer spriteRenderer)
    {
        if (spriteRenderer != null)
        {
            Debug.Log("[DEBUG 2D] Sprite obiektu: " + spriteRenderer.name + " | Kolor: " + spriteRenderer.color);
        }
    }

    // 3. Trzecia funkcja: przyjmuje klasę Transform i ją debuguje
    public void DebugujTransform(Transform transformCube)
    {
        if (transformCube != null)
        {
            Debug.Log("[DEBUG 3D] Pozycja 3D obiektu: " + transformCube.name + " | Poz X: " + transformCube.position.x);
        }
    }
}