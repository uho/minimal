\ Minimal Forth Workbench: Secondary words - Minimimal Forth words defined in terms of others  uh 2015-10-15

: DUP ( X1 -- X1 X1 )  >R R@ R> ;

: CONSTANT ( X "<Spaces>Name" -- )  CREATE , DOES> @ ;
: VARIABLE ( "<Spaces>Name" -- )  CREATE 0 , ;

: + ( N N -- N )  0 SWAP - - ;
: * ( N N -- N )  1 */MOD SWAP DROP ;
: / ( N N -- N )  1 SWAP */MOD SWAP DROP ;
: 2* ( N N -- N )  DUP + ;
: MOD ( N N -- N )  1 SWAP */MOD DROP ;
0 CONSTANT FALSE
FALSE INVERT CONSTANT TRUE
: 0= ( x -- f )  IF FALSE ELSE TRUE THEN ;
: = ( N N -- F )  - 0= ;
: > ( N N -- F )  SWAP < ;
: OR ( X X -- X )  INVERT SWAP INVERT AND INVERT ; ( do Morgan )
: XOR ( X X -- X )  OVER OVER INVERT AND >R SWAP INVERT AND R> OR ;
: LSHIFT ( X1 U -- X2 )  BEGIN DUP WHILE >R  2*  R> 1 - REPEAT DROP ;
: 2/ ( X1 -- X2 )  1 RSHIFT ;

: ROT ( X1 X2 X3 -- X2 X3 X1 )  >R  SWAP R> SWAP ;
: CHAR+ ( c-addr1 -- c-addr2 )  1 CHARS + ;
: CELL+ ( addr1 -- addr2 )  1 CELLS + ;
: ALIGNED ( addr -- a-addr )  CELL+ 1 -   1 CELLS 1 - INVERT  AND ;

