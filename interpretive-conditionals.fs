\ Interpretive conditionals (from Forth-2012 Annex A.15.6.2.2533)    uh 2015-11-01

primitive BL
primitive WORD
primitive COUNT
primitive 2DUP
primitive S"
primitive COMPARE
primitive 2DROP
primitive 1+
primitive 1-
primitive ?DUP
primitive EXIT
primitive REFILL
primitive IMMEDIATE
primitive POSTPONE

: [ELSE]  ( -- )
    1 BEGIN                               \ level
      BEGIN
        BL WORD COUNT  DUP  WHILE         \ level adr len
        2DUP  S" [IF]"  COMPARE 0=
        IF                                \ level adr len
          2DROP 1+                        \ level'
        ELSE                              \ level adr len
          2DUP  S" [ELSE]"
          COMPARE 0= IF                   \ level adr len
             2DROP 1- DUP IF 1+ THEN      \ level'
          ELSE                            \ level adr len
            S" [THEN]"  COMPARE 0= IF     \ level
              1-                          \ level'
            THEN
          THEN
        THEN ?DUP 0=  IF EXIT THEN        \ level'
      REPEAT  2DROP                       \ level
    REFILL 0= UNTIL                       \ level
    DROP
;  IMMEDIATE

: [IF]  ( flag -- ) 0= IF POSTPONE [ELSE] THEN ;  IMMEDIATE

: [THEN]  ( -- )  ;  IMMEDIATE
