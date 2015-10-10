\ Minimal Forth Workbench                                        uh 2015-10-05

: tick (  <spaces>name<spaces> -- xt f )
    state @  ] bl word find rot IF ] ELSE POSTPONE [ THEN ;

: immediate-alias ( xt <spaces>name<spaces> -- )
    CREATE , immediate DOES> @ EXECUTE ;

: non-immediate-alias ( xt <spaces>name<spaces> -- )
    CREATE , immediate DOES> @ state @ IF compile,  ELSE  EXECUTE THEN ;

variable #primitives  0 #primitives !
variable #words 0 #words !

: another-primitive ( -- )  1 #primitives +!  1 #words +! ;

: primitive ( <space>ccc<space> -- )
    get-order
    forth-wordlist 1 set-order
    another-primitive
    >in @  tick  rot >in !  0< IF non-immediate-alias ELSE immediate-alias THEN
    set-order ;


wordlist Constant minimal

minimal set-current

include primitives.fs

get-order ' set-order
minimal 1 set-order 

include prelude.fs

execute
cr .( Minimal Forth Workbench: )  #primitives @ . .( primitives, ) #words @ . .( words) cr
minimal 1 set-order
