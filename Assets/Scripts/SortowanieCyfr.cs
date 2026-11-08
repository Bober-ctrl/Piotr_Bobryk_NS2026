using System.Collections.Generic;
using UnityEngine;

public class SortowanieZadanie : MonoBehaviour
{
    void Start()
    {
        List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };

        List<int> jedynki = new List<int>();
        List<int> dwojki = new List<int>();
        List<int> trojki = new List<int>();

        while (dane.Count > 0)
        {
            int element = dane[0];

            if (element == 1)
            {
                jedynki.Add(element);
            }
            else if (element == 2)
            {
                dwojki.Add(element);
            }
            else if (element == 3)
            {
                trojki.Add(element);
            }

            dane.RemoveAt(0);
        }

        Debug.Log("Aktualna liczba elementów w 'dane': " + dane.Count);
        Debug.Log("Liczba jedynek: " + jedynki.Count);
        Debug.Log("Liczba dwójek: " + dwojki.Count);
        Debug.Log("Liczba trójek: " + trojki.Count);
    }
}