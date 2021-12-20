using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Public Variables

    public TextMeshProUGUI Text;
    public SpriteRenderer Charactera;
    public Sprite Zack;
    public SpriteRenderer Characterb;
    public Sprite Daniellia;
    public Sprite Kavon;
    public Sprite Mya;
    public Sprite Jaihad;
    public Sprite Starlyn;
    public Sprite Kevin;
    public Sprite Kathy;
    public Sprite Briana;
    public SpriteRenderer BG;
    public List<CharacterLines> GameDialogue= new List<CharacterLines>();
    public int pg = 0;
    public Sprite Classroom;

    void Start()
    {
        GameFlow();
        GameDialogue:
        SetLine(GameDialogue[0]);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pg += 1;
            if (pg >= GameDialogue.Count)
            {
                SceneManager.LoadScene("Choice"); 
                Debug.Log("Game Started");
            }
            else
                SetLine(GameDialogue[pg]);
        }
    }

    void SetLine(CharacterLines cl)
    {
        Text.text = cl.Text;
        if (cl.Charactera == Characters.Zack)
            Charactera.sprite = Zack;
        if (cl.Charactera == Characters.Daniellia)
            Charactera.sprite = Daniellia;
        if (cl.Characterb == Characters.Zack)
            Characterb.sprite = Zack;
        if (cl.Characterb == Characters.Daniellia)
            Characterb.sprite = Daniellia;
        if (cl.Charactera == Characters.Kavon)
            Charactera.sprite = Kavon;
        if (cl.Characterb == Characters.Kavon)
            Characterb.sprite = Kavon;
        if (cl.Charactera == Characters.Mya)
            Charactera.sprite = Mya;
        if (cl.Characterb == Characters.Mya)
            Characterb.sprite = Mya;
        if (cl.Charactera == Characters.Jaihad)
            Charactera.sprite = Jaihad;
        if (cl.Characterb == Characters.Jaihad)
            Characterb.sprite = Jaihad;
        if (cl.Charactera == Characters.Kevin)
            Charactera.sprite = Kevin;
        if (cl.Characterb == Characters.Kevin)
            Characterb.sprite = Kevin;
        if (cl.Charactera == Characters.Starlyn)
            Charactera.sprite = Starlyn;
        if (cl.Characterb == Characters.Starlyn)
            Characterb.sprite = Starlyn;
        if (cl.Charactera == Characters.Kathy)
            Charactera.sprite = Kathy;
        if (cl.Characterb == Characters.Kathy)
            Characterb.sprite = Kathy;
        if (cl.Charactera == Characters.Briana)
            Charactera.sprite = Briana;
        if (cl.Characterb == Characters.Briana)
            Characterb.sprite = Briana;
            
        {
            
        }
        
            if (cl.BG == BGSettings.Classroom)
            BG.sprite = Classroom;
    }

    void GameFlow()
    {
        GameDialogue.Add(new CharacterLines("Zack: Alright guys, this is the moment we’ve been waiting for", Characters.Zack , Characters.Zack , BGSettings.Classroom));
        GameDialogue.Add(new CharacterLines("Daniellia: After this we’re gonna have a large pow wow circle about killing giant hands", Characters.Zack , Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Zack: no one cares Daniellia, Kavon how should we do this?", Characters.Zack , Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Kavon: We’ll each need to take down about 10.", Characters.Zack , Characters.Kavon));
        GameDialogue.Add(new CharacterLines("Zack: Sounds challenging but if we gotta do it this way then let’s do it!", Characters.Zack , Characters.Kavon));
        GameDialogue.Add(new CharacterLines("Mya:  If you wanna square up, prepare for the clap back. You hear me?", Characters.Mya , Characters.Kavon));
        GameDialogue.Add(new CharacterLines("Zack: I don’t think she heard the plan", Characters.Mya , Characters.Zack));
        GameDialogue.Add(new CharacterLines("Daniellia: Leave her, she’s in her own world", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines("Zack: Lemme tell her ", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines("Zack: Ay yo Mya, we gotta take down ten of these master hands by ourselves ", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Mya: G U R L WHAT!? ", Characters.Mya , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Mya: Yeah G UR L ! You heard me.", Characters.Mya , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Mya: Nah fam, that’s a lot of work", Characters.Mya , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Daniellia: M Y a", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Mya: Nah fam home girl did a lot of shit to get here and i don't vibe with it. I'm outta here!", Characters.Daniellia , Characters.Mya));
        GameDialogue.Add(new CharacterLines("Daniellia: I hope she’ll be ok..", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Zack: Dani, it’s ok, she’ll be fine, it’s Mya, what’s the worst that can happen?", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Daniella: sigh, I guess so", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines(" Jaihad: WHO WANTS EMULATORS ON THEIR PHONE?", Characters.Daniellia , Characters.Jaihad));
        GameDialogue.Add(new CharacterLines(" Daniellia: J AI HAD", Characters.Daniellia , Characters.Jaihad));
        GameDialogue.Add(new CharacterLines(" Jaihad: What now?", Characters.Daniellia , Characters.Jaihad));
        GameDialogue.Add(new CharacterLines("Daniellia: WHAT DO YOU MEAN WHAT NOW? MYA IS MY BFF AN-", Characters.Daniellia , Characters.Jaihad));
        GameDialogue.Add(new CharacterLines("Starlyn: ITS COMING GUYS!", Characters.Daniellia , Characters.Starlyn));
        GameDialogue.Add(new CharacterLines("With that being said, the infamous Thanos beam starts to attack the group", Characters.Daniellia , Characters.Starlyn));
        GameDialogue.Add(new CharacterLines("As the beams continued to rain down, they try to defend themselves, everyone began to scatter", Characters.Daniellia , Characters.Starlyn));
        GameDialogue.Add(new CharacterLines("Someone who had a somewhat small brain decided to attempt to stop the beams ", Characters.Daniellia , Characters.Kevin));
        GameDialogue.Add(new CharacterLines("Kevin: Don't worry I’ll flex off my cat to score brownie points and to stop the beam", Characters.Daniellia , Characters.Kevin));
        GameDialogue.Add(new CharacterLines("Kevin takes his cat Poe out his pocket and lifts them into the sky", Characters.Daniellia , Characters.Kevin));
        GameDialogue.Add(new CharacterLines("Kathy and Briana: OMGITSKEVINSCAT!", Characters.Kathy , Characters.Briana)); 
        GameDialogue.Add(new CharacterLines("Daniellia : Poe, how ‘bout no(e)", Characters.Daniellia , Characters.Briana)); 
        GameDialogue.Add(new CharacterLines("Kevin: oof", Characters.Daniellia , Characters.Kevin)); 
        GameDialogue.Add(new CharacterLines("Daniellia: Kev there’s something called V A R I T E Y", Characters.Daniellia , Characters.Kevin)); 
        GameDialogue.Add(new CharacterLines("Kevin: How dare you", Characters.Daniellia , Characters.Kevin));
        GameDialogue.Add(new CharacterLines("Daniellia: Well I don't care about your cat.", Characters.Daniellia , Characters.Kevin));
        GameDialogue.Add(new CharacterLines("Kevin: Wha-", Characters.Daniellia , Characters.Kevin));
        GameDialogue.Add(new CharacterLines("*kevin and his pets gets disintegrated", Characters.Daniellia , Characters.Kevin));
        GameDialogue.Add(new CharacterLines("*Daniellia: Oh no Kev!", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines("Zack: you sound like you didn’t care", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines("Daniella: eh he’ll be fine", Characters.Daniellia , Characters.Zack));
        GameDialogue.Add(new CharacterLines("After seeing Poe die, Kathy gave up on the world, she lost the most weird looking cat that she thought was adorable, There was no BTS to cheer her up. So she decided upon herself to break down and cry", Characters.Daniellia , Characters.Kathy));
        GameDialogue.Add(new CharacterLines("Daniellia: KAT! NO!", Characters.Daniellia , Characters.Kathy));
        GameDialogue.Add(new CharacterLines("Kathy: But but but Poe is dead, BTS is gone, WHAT IS THERE TO DO!?", Characters.Daniellia , Characters.Kathy));
        GameDialogue.Add(new CharacterLines("Zack: Probably not obsess over a cat?", Characters.Zack, Characters.Kathy));
        GameDialogue.Add(new CharacterLines("Kathy: Nuuuuu!", Characters.Zack, Characters.Kathy));
        GameDialogue.Add(new CharacterLines("Too shocked and depressed to move Kathy got caught in the beam", Characters.Zack, Characters.Kathy));
        GameDialogue.Add(new CharacterLines("Daniellia: F U D GE MY FREINDS IS DYING, OMG NO---", Characters.Zack, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Jaihad: welp I’ll see you guys later, gotta skeet", Characters.Jaihad, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Daniellia: J A I HAD, IF YOU DONT GET YOUR UGLY SE-", Characters.Jaihad, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Jaihad: TOO LATE!", Characters.Jaihad, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("As Jaihad tries to run away with his stuff he trips, as he falls he de integrates, He does a rather clique anime character smile and dies", Characters.Jaihad, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Before Daniellia could even comment on the pathetic display, she receives a phone call from her mother. ", Characters.Zack, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Mom: Sven WHERE ARE YOU, YOURE SUPPOSE TO BE HOME, ARE YOU AND KEVIN DOING INAPPROPRIATE THINGS?", Characters.Zack, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Daniellia: M o M No...", Characters.Zack, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Daniellia's mom ranted on and ranted on untill the line got cut off. Her mother was erased", Characters.Zack, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Daniellia: F I BALLY IM FUCKING FREE NOW IM GONNA MAKE LINK in my RWBY X ZELDA FANFICTION DEPRESSE", Characters.Zack, Characters.Daniellia));
        GameDialogue.Add(new CharacterLines("Daniellia was erased.. just like that ", Characters.Zack));
        GameDialogue.Add(new CharacterLines("Zack: so much for freedom, Alrighty, Starlyn and Briana, Let's charge in!", Characters.Zack));
        GameDialogue.Add(new CharacterLines("As Zack quickly turns around he sees a beam engulf two people, Starlyn and Briana were deleted.", Characters.Zack));
        GameDialogue.Add(new CharacterLines("He then sees a ripped cloth in the corner, He assumes that Kavon got erased as well", Characters.Zack));
        GameDialogue.Add(new CharacterLines("He charges in to fight the monstrosity but instantly gets erased", Characters.Zack));

        

        



    }
    
}
