#slime: default
Alright let’s see what we have here…
(Please select the color button on the right side)
   *[Blue] #potion: bluePotion #namePotion: Sprite #sfx: ps
        ...
        Fizzy...  #slime: blue1 #morph1: s #potion: blank #namePotion: 
        ->chooseblue
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: ps
        ...
        Smell like porkchop #slime: red1 #morph1: s #potion: blank #namePotion: 
        ->choosered
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: ps
        ...
        This smell... dangerous #slime: pink1 #morph1: s #potion: blank #namePotion: 
        ->choosepink
== chooseblue ==
I don’t think this is enough 
Maybe we need another substance
    *[Blue] #potion: bluePotion #namePotion: Sprite  #sfx: ps
        ...
        Woah is that a horn?#slime: NatsuSlime #morph2: s #potion: blank #namePotion:
        Also a fang…
        ->Ending1N
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: ps
        ...
        Huh- this wasn’t what I was expecting #slime: SoiSlime #morph2: s #potion: blank #namePotion: 
        Ah- don’t cry, I didn’t say you were bad
        I’ll treat you with absolute care ok?
        ->Ending1S
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: ps
        ...
        This- #slime: PunSlime #sfx:morph2 #morph2: s #potion: blank #namePotion: 
        This is-
        It’s a cat
        ->Ending1P
    
== choosered ==
    I don’t think this is enough #potion: blank #namePotion: 
    Maybe we need another substance
    *[Blue] #potion: bluePotion #namePotion: Sprite #sfx: ps
        ...
        Huh- this wasn’t what I was expecting #slime: SoiSlime #potion: blank #namePotion: #morph2: s
        Ah- don’t cry, I didn’t say you were bad
        I’ll treat you with absolute care ok?
        ->Ending1S
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: ps
        ...
        Oh- #slime: meatySlime #potion: blank #namePotion: #morph2: s
        Woah-
        Don’t get discouraged! You’re...
        Beautiful the way you are!
        ->Ending2
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: ps
        ...
        Woah… #slime: mermaid #potion: blank #namePotion: #morph2: s
        So cute and tiny!
        ->Ending3
==choosepink==
    I don’t think this is enough #potion: blank #namePotion: 
    Maybe we need another substance
    *[Blue] #potion: bluePotion #namePotion: Sprite #sfx: ps
        ...
        This- #slime: PunSlime #potion: blank #namePotion: #morph2: s
        This is-
        It’s a cat
        ->Ending1P
    *[Red] #potion: redPotion #namePotion: Meaty #sfx: ps
        ...
        Woah… #slime: mermaid #potion: blank #namePotion: #morph2: s
        So cute and tiny!
        ->Ending3
    *[Pink] #potion: pinkPotion #namePotion: UwU #sfx: ps
        ...
        what the... #slime: pinkdust #potion: blank #namePotion: #morph2: s
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
#vdo: End2
->END
==Ending3==
#vdo: End3
->END
==Ending4==
#vdo: End4
->END