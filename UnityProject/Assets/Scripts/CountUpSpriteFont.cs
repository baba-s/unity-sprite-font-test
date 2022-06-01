using UnityEngine;

public sealed class CountUpSpriteFont : MonoBehaviour
{
    [SerializeField] private SpriteFont m_spriteFont;
    [SerializeField] private float      m_duration;

    private int   m_count;
    private float m_elapsedTime;

    private void Update()
    {
        m_elapsedTime += Time.deltaTime;

        if ( m_elapsedTime < m_duration ) return;

        m_elapsedTime -= m_duration;

        m_spriteFont.SetValue( m_count );
        m_count++;
    }
}