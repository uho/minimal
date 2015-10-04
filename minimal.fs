\ Minimal Forth word set                    uh 2015-10-04

: min-n ( -- x )
    -1 BEGIN dup 2* dup WHILE  swap drop REPEAT drop ;

: U2/ ( u -- u )  2/  [ min-n invert ] Literal and ;

: primitive ( <space>ccc<space> -- ) ;

wordlist Constant minimal

minimal set-current

\ primitive !
\ primitice , ...

' ! alias !
' , alias ,
' @ alias @
\ ' align alias ALIGN
' aligned alias ALIGNED
' cell+ alias CELL+
' cells alias CELLS
' c! alias C!
' c, alias C,
' c@ alias C@
: CALIGN ;
: CALIGNED ;
\ ' char+ alias CHAR+ 
' chars alias CHARS

' */mod alias */MOD
' - alias -
' 2/ alias 2/
' u2/ ( u -- u )  alias u2/

\ ' 0= alias 0=
' < alias <
' and alias AND
' invert alias INVERT

\ ' dup alias DUP
' swap alias SWAP
' >r alias >R
' r@ alias R@
' drop alias DROP
' over alias OVER
' r> alias R>

\ primitive IF
: IF postpone IF ; immediate
: THEN postpone THEN ; immediate
: WHILE postpone WHILE ; immediate
: REPEAT postpone REPEAT ; immediate
: DO postpone DO ; immediate
' I alias I
' ' alias '
: ELSE postpone ELSE ; immediate
: BEGIN postpone BEGIN ; immediate
\ : AGAIN postpone AGAIN ; immediate
: UNTIL postpone UNTIL ; immediate
: LOOP postpone LOOP ; immediate
' J alias J
' EXECUTE alias EXECUTE

' : alias :
' CREATE alias CREATE 
: ; postpone ; ; immediate
: DOES> postpone does> ; immediate

' key alias KEY
' emit alias EMIT
' key? alias KEY?
' cr alias CR

: ( postpone ( ; immediate
' .s alias .S
: \ postpone \ ; immediate

' bye alias bye
' include alias INCLUDE
' words alias WORDS
\ ' order alias order

' postpone alias POSTPONE immediate
' immediate alias IMMEDIATE
' >body alias >BODY
\ ' compile, alias COMPILE,
: SLITERAL postpone sliteral ; immediate
: LITERAL  postpone literal ; immediate
' compile, alias COMPILE,

' parse alias PARSE

: EXIT  postpone exit ; immediate

: :?  >in @  parse-name find-name IF  drop  postpone \  ELSE  >in !  : THEN ;

get-order ' set-order

minimal 1 set-order 

include prelude.fs

execute

cr .( Minimal Forth word set activated )  cr

minimal 1 set-order
