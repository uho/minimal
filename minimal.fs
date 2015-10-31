\ Minimal Forth Workbench: main file                                        uh 2015-10-05

: tick (  <spaces>name<spaces> -- comp-xt exec-xt flag )
    STATE @ >R
    ] >IN @ >R  BL WORD FIND
    IF R> >IN !
       POSTPONE [  BL WORD FIND
    ELSE R> DROP
       DROP 0 0 false
    THEN
    R> IF ] ELSE POSTPONE [ THEN ;

: immediate-alias ( comp-xt exec-xt <spaces>name<spaces> -- )
    CREATE , , IMMEDIATE DOES> STATE @ IF CELL+ THEN  @ EXECUTE ;

: non-immediate-alias ( comp-xt exec-xt <spaces>name<spaces> -- )
    CREATE , , IMMEDIATE DOES> STATE @ IF CELL+ @ COMPILE,  ELSE  @ EXECUTE THEN ;

VARIABLE #primitives  0 #primitives !
VARIABLE #words 0 #words !

: another-primitive ( -- )  1 #primitives +!  1 #words +! ;

wordlist Constant minimal

: primitive ( <space>ccc<space> -- )
    get-order
      minimal 1 set-order   >IN @ >R  tick R> >IN ! NIP NIP
      0= IF
        forth-wordlist 1 set-order
        another-primitive
        >IN @ >R tick  R> >IN !  DUP 0= Abort" ?"
        0< IF non-immediate-alias ELSE immediate-alias THEN
      ELSE
        CR BL WORD COUNT TYPE ."  is already defined."
      THEN
    set-order ;


minimal set-current

include primitives.fs    \ Minimal Forth primitives

get-order ' set-order
minimal 1 set-order

include prelude.fs  \ System configuration

execute
cr .( Minimal Forth Workbench: )  #primitives @ . .( primitives, ) #words @ . .( words) cr
minimal 1 set-order
