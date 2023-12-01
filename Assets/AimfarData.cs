using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Interaction level enum. Static: no interaction, Linear: One Axis Interaction, Polydimensional: Multi Axis Interaction
public enum InteractionLevel{Static,Linear,Polydimensional} 

// Axis Iteratatiom method enum. Linear: Layered One by one, Binary: On or Off, Select: single selection from list
public enum AxisIterationMethod{Linear,Binary,Select}

// Interaction Axis Class
public class InteractionAxis : MonoBehaviour
{
    public List<AudioClip> MemberClips; // List of audio clips
    public AxisIterationMethod IterationMethod; // Iteration method
}



public class AimfarData : ScriptableObject // Data container class inherits from ScriptableObject
{
    //       MUSES VERITAS AND,     ALAS ASABOVSOVELO   TENET PROMETHEUS  
    //      HOUSES   AIM   STARS   ALIGN FAC           ~OPERA ONE    HERE 
    //     PERSIST   FAR   STELLA.ORNATA GCE          FOREVER FOR    FOR 
    //    TUES DAY   RUN   CONSTANTINELUCIUSPALLAS   BURN TEN ALL   LOVE 
    //   LONG  DAY   FAR   AND YIELD NOT ESC        MAKE  ONE OCTANGULE   
    //  GOOD   DAY   GET   FOR  THE  BOW END       FEEL   BAD ALL FIRE    ╔═╗╦╔╦╗|╔═╗╔═╗╦═╗  [𝔸𝔻 𝔸𝕊𝕋ℝ𝔸 ℙ𝔼ℝ 𝔸𝕊ℙ𝔼ℝ𝔸]
    // TOTHESTARS!   FAR   NOR   -   FOR ALT      PEACEFORALL FOR  FROM   ╠═╣║║║║|╠╣ ╠═╣╠╦╝  𝓐𝓓𝓐𝓢𝓣𝓡𝓐 𝓘𝓝𝓣𝓔𝓡𝓐𝓒𝓣𝓘𝓥𝓔 𝓜𝓤𝓢𝓘𝓒
    //2909     SEE VERITAS HER       EYE DEL     LIVE     DIE ONE   GODS  ╩ ╩╩╩ ╩|╚  ╩ ╩╩╚═* 𝓕𝓞𝓡𝓜𝓐𝓣 - 𝓐𝓖𝓝𝓞𝓢𝓣𝓘𝓒 𝓡𝓔𝓓𝓘𝓢𝓣𝓡𝓘𝓑𝓤𝓣𝓐𝓑𝓛𝓔 
    // 
    // AIMFAR VERSION 01_MKA "ALBEDO"
    // Copyright Constantine Pallas 2023  
    // Song Data Class

    public Image _AlbumCover; // Album cover image
    public string _SongTitle;  // Song title
    public InteractionLevel _InteractionLevel; // Interaction level
    public List<InteractionAxis> _InteractionAxes; // List of interaction axes

}
