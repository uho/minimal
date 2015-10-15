\ Minimal Forth Workbench: definitions of primitives                  uh 2015-10-10

primitive !
primitive ,
primitive @
primitive ALIGN
\ primitive ALIGNED
\ primitive CELL+
primitive CELLS
primitive C!
primitive C,
primitive C@
: CALIGN ;   another-primitive
: CALIGNED ; another-primitive
\ primitive CHAR+
primitive CHARS

\ primitive + 
\ primitive *
\ primitive 2*
primitive */MOD
primitive -
\ primitive /
\ primitive 2/
\ primitive MOD

\ primitive 0=
primitive <
primitive AND
primitive INVERT
\ primitive TRUE
\ primitive LSHIFT
\ primitive =
\ primitive >
\ primitive OR
\ primitive XOR
\ primitive FALSE
primitive RSHIFT

\ primitive DUP
primitive SWAP
primitive >R
primitive R@
primitive DROP
primitive OVER
primitive R>

primitive IF
primitive THEN
primitive WHILE
primitive REPEAT
primitive DO
primitive I
primitive '
primitive ELSE
primitive BEGIN
primitive AGAIN
primitive UNTIL
primitive LOOP
primitive J
primitive EXECUTE

\ primitive :
: :   :             1 #words +! ; another-primitive
\ primitive CONSTANT
\ primitive CREATE
: CREATE   CREATE   1 #words +! ; another-primitive
primitive ;
\ primitive VARIABLE
primitive DOES>

primitive KEY
primitive EMIT
primitive KEY?
primitive CR

primitive (
primitive .S
primitive \

: bye bye ;
: INCLUDE include ;
\ primitive WORDS
: WORDS   WORDS   CR #primitives @ . ." primitives, " #words @ . ." words" ;
\ : order  order ;

\ primitive EXIT

: primitive primitive ;