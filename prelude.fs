\ Minimal Forth Workbench - Minimimal Forth words defined in terms of others         uh 2015-10-10

: DUP ( X1 -- X1 X1 )  >R R@ R> ;

: CONSTANT ( X "<Spaces>Name" -- )  CREATE , DOES> @ ;
: VARIABLE ( "<Spaces>Name" -- )  CREATE 0 , ;

: + ( N N -- N )  0 SWAP - - ;
: * ( N N -- N )  1 */MOD SWAP DROP ;
: / ( N N -- N )  1 SWAP */MOD SWAP DROP ;
: 2* ( N N -- N )  dup + ;
: MOD ( N N -- N )  1 SWAP */MOD DROP ;
0 CONSTANT FALSE
FALSE INVERT CONSTANT TRUE
: 0= ( x -- f )  IF FALSE ELSE TRUE THEN ;
: = ( N N -- F )  - 0= ;
: > ( N N -- F )  SWAP < ;
: OR ( X X -- X )  INVERT SWAP INVERT AND INVERT ; ( do Morgan )
: XOR ( X X -- X )  OVER OVER INVERT AND >R SWAP INVERT AND R> OR ;
: LSHIFT ( X1 U -- X2 )  DUP IF  0 DO  2*  LOOP  THEN ;
: 2/ ( X1 -- X2 )  1 RSHIFT ;

: ROT ( X1 X2 X3 -- X2 X3 X1 )  >R  SWAP R> SWAP ;
: CHAR+ ( c-addr1 -- c-addr2 )  1 CHARS + ;
: CELL+ ( addr1 -- addr2 )  1 CELLS + ;
: ALIGNED ( addr -- a-addr )  CELL+ 1 -   1 CELLS 1 - INVERT  AND ;

\ other useful words

\ : COUNT ( addr1 -- addr2 len )  DUP CHAR+ SWAP C@ ;
\ : TYPE ( addr len -- )  DUP IF  OVER + SWAP DO  I C@ EMIT  LOOP  THEN ;

\ : DEFER ( xt "<Spaces>Name" -- )  CREATE , DOES> @ EXECUTE ;
\ : VALUE ( n "<Spaces>Name" -- )  CREATE , DOES> @ ;

\ if POSTPONE and IMMEDIATE were available:
\ : AGAIN   POSTPONE FALSE  POSTPONE UNTIL ; IMMEDIATE
\ : ?EXIT   POSTPONE IF  POSTPONE EXIT  POSTPONE THEN ; IMMEDIATE

\ if LITERAL would be available:
\ : [']  ' POSTPONE LITERAL ; IMMEDIATE

\ if >BODY would be available:
\ : IS ( xt "<Spaces>Name" -- )  ' >BODY ! ;

\ if PARSE and SLITERAL were available:
\ : ."   34 PARSE POSTPONE SLITERAL POSTPONE TYPE ; IMMEDIATE
\ : .(   41 PARSE TYPE ; IMMEDIATE

