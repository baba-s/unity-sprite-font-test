using System;
using UnityEngine;

public sealed class SpriteFont : MonoBehaviour
{
    [SerializeField] private Sprite[]         m_spriteArray;
    [SerializeField] private SpriteRenderer[] m_spriteRendererArray;
    [SerializeField] private float            m_interval;

    private void Awake()
    {
        SetValue( 0 );
    }

    public void SetValue( int value )
    {
        var digits = value == 0 ? 1 : ( int ) Math.Log10( value ) + 1;

        for ( var i = 0; i < m_spriteRendererArray.Length; i++ )
        {
            var reversedIndex  = digits - i - 1;
            var x              = m_interval * reversedIndex - ( m_interval * digits * 0.5f ) + m_interval * 0.5f;
            var spriteRenderer = m_spriteRendererArray[ i ];

            spriteRenderer.transform.localPosition = new Vector3( x, 0, 0 );

            if ( digits <= i )
            {
                spriteRenderer.enabled = false;
                continue;
            }

            var index = value % 10;

            spriteRenderer.enabled = true;
            spriteRenderer.sprite  = m_spriteArray[ index ];

            value /= 10;
        }
    }
}