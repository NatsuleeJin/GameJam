#slime: default
Alright let’s see what we have here…
(Please select the color button on the right side)
   *[Blue] #potion: bluePotion #namePotion: Sprite #sfx: potionsound
        Fizzy...
        ->chooseblue
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: potionsound
        Smell like porkchop
        ->choosered
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: potionsound
        This smell... dangerous
        ->choosepink
== chooseblue ==
I don’t think this is enough #potion: blank #namePotion: 
Maybe we need another substance
    *[Blue] #potion: bluePotion #namePotion: Sprite  #sfx: potionsound
        Woah is that a horn?#slime: NatsuSlime #potion: blank #namePotion: 
        Also a fang…
        ->Ending1N
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: potionsound
        Huh- this wasn’t what I was expecting #slime: SoiSlime #potion: blank #namePotion: 
        Ah- don’t cry, I didn’t say you were bad
        I’ll treat you with absolute care ok?
        ->Ending1S
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: potionsound
        This- #slime: PunSlime #potion: blank #namePotion: 
        This is-
        It’s a cat
        ->Ending1P
    
== choosered ==
    I don’t think this is enough #potion: blank #namePotion: 
    Maybe we need another substance
    *[Blue] #potion: bluePotion #namePotion: Sprite #sfx: potionsound
        Huh- this wasn’t what I was expecting #slime: SoiSlime #potion: blank #namePotion: 
        Ah- don’t cry, I didn’t say you were bad
        I’ll treat you with absolute care ok?
        ->Ending1S
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: potionsound
        Oh- #slime: meatySlime #potion: blank #namePotion: 
        Woah-
        Don’t get discouraged! You’re...
        Beautiful the way you are!
        ->Ending2
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: potionsound
        Woah… #slime: mermaid #potion: blank #namePotion: 
        So cute and tiny!
        ->Ending3
==choosepink==
    I don’t think this is enough #potion: blank #namePotion: 
    Maybe we need another substance
    *[Blue] #potion: bluePotion #namePotion: Sprite #sfx: potionsound
        This- #slime: PunSlime #potion: blank #namePotion: 
        This is-
        It’s a cat
        ->Ending1P
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: potionsound
       Woah… #slime: mermaid #potion: blank #namePotion: 
        So cute and tiny!
        ->Ending3
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: potionsound
        what the... #slime: pinkdust #potion: blank #namePotion: 
       ->Ending4

==Ending1N== 
#vdo: End1N
->END
==Ending1S==
#vdo: End1S
->END
==Ending1P==
#vdo: End1P
->END
==Ending2==
.#bgImg: End2_Ani
.#vdo: End2
->END
==Ending3==
#vdo: End3
->END
==Ending4==
#vdo: End4
->END