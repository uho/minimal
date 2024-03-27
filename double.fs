\ Minimal Forth Workbench: double words                                      uh 2015-10-15

: 2DUP ( d1 -- d1 d1 )  OVER OVER ;
: 2SWAP ( d1 d2 -- d2 d1 )  >R ROT ROT R> ROT ROT ;
: 2OVER ( d1 d2 -- d1 d2 d1 )  >R >R 2DUP R> R> 2SWAP ;
: 2DROP ( x1 x2 -- )  DROP DROP ;

: 2VARIABLE ( -- )  CREATE 0 , 0 , ;

primitive 2@
: 2CONSTANT ( x1 x2 -- )  CREATE , , DOES> 2@ ;

primitive POSTPONE
: 2>R ( x1 x2 -- ) ( R: -- x2 x1 ) POSTPONE >R  POSTPONE >R ; IMMEDIATE
: 2R> ( R: x1 x2 -- ) ( -- x2 x1 )  POSTPONE R>  POSTPONE R> ; IMMEDIATE
: 2R@ ( R: x1 x2 -- x1 x2 ) ( -- x2 x1 )   POSTPONE 2R>  POSTPONE 2DUP  POSTPONE 2>R ; IMMEDIATE
: 2ROT ( d1 d2 d3 -- d2 d3 d1 )  2>R 2SWAP 2R> 2SWAP ;

primitive LITERAL
: 2LITERAL ( x1 x2 -- )  SWAP POSTPONE LITERAL  POSTPONE LITERAL ; IMMEDIATE
