using TMPro;
using UnityEngine;

public sealed class CountUpTextMeshPro : MonoBehaviour
{
    [SerializeField] private TMP_Text m_tmpText;
    [SerializeField] private float    m_duration;

    private int   m_count;
    private float m_elapsedTime;

    private void Update()
    {
        m_elapsedTime += Time.deltaTime;

        if ( m_elapsedTime < m_duration ) return;

        m_elapsedTime -= m_duration;

        m_tmpText.SetText( "{0}", m_count );
        m_count++;
    }
}