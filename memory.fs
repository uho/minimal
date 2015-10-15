\ Minimal Forth Workbench: more memory operators        uh 2015-10-15

: 2! ( d addr -- )   SWAP OVER ! CELL+ ! ;
: 2@ ( addr -- d )  DUP CELL+ @ SWAP @ ;

: +! ( x addr -- )  SWAP OVER @ + SWAP ! ;

: CMOVE ( c-addr1 c-addr2 u -- )
   BEGIN ( c-addr1 c-add2 u )
     DUP
   WHILE ( c-addr1 c-addr2 u )
      >R  OVER C@  OVER C!   SWAP CHAR+ SWAP CHAR+  R> 1 -
   REPEAT ( c-add1 c-add2 u )
   DROP DROP DROP ;