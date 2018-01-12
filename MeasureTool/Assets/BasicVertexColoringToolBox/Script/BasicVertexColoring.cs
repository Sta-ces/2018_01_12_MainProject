using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicVertexColoring  : MonoBehaviour
{

    #region Public Members
    
    public enum e_colorState
    {
        NONE,
        GREEN,
        RED,
        BLUE,
        BLACK,
        CYAN,
        YELLOW,
        WHITE,
        MAGENTA,
        GREY
    }
    [Header("Be aware some materials don't show vertexcolor")]
    public e_colorState m_colorState1 = e_colorState.NONE;
    public e_colorState m_colorState2 = e_colorState.NONE;
    #endregion
    
    #region System

    void Awake () 
    {
        m_currentobject = this.gameObject;
        if(m_currentobject.GetComponent<MeshFilter>())
        {
            m_mesh = GetComponent<MeshFilter>().mesh;
            ChangeColor();
        }
    }

    #endregion

    #region Public Void
    public void SetColor1(e_colorState col)
    {
        m_colorState1 = col;
        ColorAssign();
    }
    public void SetColor2(e_colorState col)
    {
        m_colorState2 = col;
        ColorAssign();
    }
    public e_colorState GetColor1()
    {
        return m_colorState1;
    }
    public e_colorState GetColor2()
    {
        return m_colorState2;
    }
    
    #endregion

    #region Private Void
    private void ChangeColor()
    {
        Vector3[] vertices = m_mesh.vertices;
        // create new colors array where the colors will be created.
        Color[] colors = new Color[vertices.Length];

        

        if(m_colorState1 != e_colorState.NONE && m_colorState2 != e_colorState.NONE)
        {
            ColorAssign();
            for (int i = 0; i < vertices.Length; i++)
            {
                colors[i] = Color.Lerp(m_color1, m_color2, vertices[i].y);
            }
            m_mesh.colors = colors;
        }
        else
        {
            if (m_colorState1 != e_colorState.NONE)
            {
                ColorAssign();
                for (int i = 0; i < vertices.Length; i++)
                {
                    colors[i] = m_color1;
                }
                m_mesh.colors = colors;
            }
            else
            {
                if (m_colorState2 != e_colorState.NONE)
                {
                    ColorAssign();
                    for (int i = 0; i < vertices.Length; i++)
                    {
                        colors[i] = m_color2;
                    }
                    m_mesh.colors = colors;
                }
            }
        }
    }

    private void ColorAssign()
    {
        switch(m_colorState1)
        {
            case e_colorState.GREEN:
                m_color1 = Color.green;
                break;
            case e_colorState.BLUE:
                m_color1 = Color.blue;
                break;
            case e_colorState.RED:
                m_color1 = Color.red;
                break;
            case e_colorState.BLACK:
                m_color1 = Color.black;
                break;
            case e_colorState.CYAN:
                m_color1 = Color.cyan;
                break;
            case e_colorState.YELLOW:
                m_color1 = Color.yellow;
                break;
            case e_colorState.WHITE:
                m_color1 = Color.white;
                break;
            case e_colorState.MAGENTA:
                m_color1 = Color.magenta;
                break;
            case e_colorState.GREY:
                m_color1 = Color.grey;
                break;
            default: break;
        }
        switch (m_colorState2)
        {
            case e_colorState.GREEN:
                m_color2 = Color.green;
                break;
            case e_colorState.BLUE:
                m_color2 = Color.blue;
                break;
            case e_colorState.RED:
                m_color2 = Color.red;
                break;
            case e_colorState.BLACK:
                m_color2 = Color.black;
                break;
            case e_colorState.CYAN:
                m_color2 = Color.cyan;
                break;
            case e_colorState.YELLOW:
                m_color2 = Color.yellow;
                break;
            case e_colorState.WHITE:
                m_color2 = Color.white;
                break;
            case e_colorState.MAGENTA:
                m_color2 = Color.magenta;
                break;
            case e_colorState.GREY:
                m_color2 = Color.grey;
                break;
            default: break;
        }
    }
    #endregion
    

    #region Private And Protected Members
    private GameObject m_currentobject;
    private Mesh m_mesh;
    private Color m_color1;
    private Color m_color2;
    #endregion

}
