using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLines
{
    public Characters Charactera;
    public Characters Characterb;
    public BGSettings BG = BGSettings.Hallway;
    public string Text = "meow";

    public CharacterLines(string txt,Characters a=Characters.Nobody,Characters b=Characters.Nobody,BGSettings bg = BGSettings.Classroom)
    {
        Text = txt;
        Charactera = a;
        Characterb = b;
        BG = bg;

    }
}

public enum Characters
{
    Nobody,
    Zack,
    Daniellia,
    Kavon,
    Mya,
    Jaihad,
    Starlyn,
    Kevin,
    Kathy,
    Briana,
}

public enum BGSettings
{
    Classroom,
    Hallway,
    Floor,
    MishaClassroom,
}
