using UnityEngine;

public class GradientZadanie6 : MonoBehaviour
{
    public Gradient gradientKolorow;
    public float maksymalnaPozycjaY = 100f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (spriteRenderer != null && gradientKolorow != null)
        {
            float pozycjaY = transform.position.y;
            float znormalizowanaPozycja = Mathf.Clamp01(pozycjaY / maksymalnaPozycjaY);
            spriteRenderer.color = gradientKolorow.Evaluate(znormalizowanaPozycja);
        }
    }
}