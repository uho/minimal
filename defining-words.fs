\ Minimal Forth Workbench: defining words                                  uh 2015-10-15

: VALUE ( -- )  CREATE , DOES> @ ;

\ TO is a state smart compiling word

: DEFER ( "<Spaces>Name" -- )  CREATE 0 , DOES> @ EXECUTE ;

primitive ALLOT
primitive HERE

\ : Array ( n -- )  CREATE CELLS ALLOT DOES> ( i -- x ) CELLS + ;
\ : Field ( u1 u2 -- u3 )  CREATE  OVER , + DOES> ( addr -- ) @  + ;

