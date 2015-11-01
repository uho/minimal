\ Minimal Forth Workbench: arithmetic words                            uh 2015-10-15

: 0< ( n -- f ) 0 < ;
: 1+ ( x1 -- x2 ) 1 + ;
: 2+ ( x1 -- x2 ) 2 + ;
: 1- ( x1 -- x1 ) 1 - ;
: 0<> ( x -- f ) - 0= ;
: 0> ( n1 -- f )  0 > ;
: <> ( x1 x2 -- f ) = 0= ;
: NEGATE ( n1 -- n2 ) 0 SWAP - ;

: MIN ( n1 n2 -- n3 )  OVER OVER > IF SWAP THEN DROP ;
: MAX ( n1 n2 -- n3 )  OVER OVER < IF SWAP THEN DROP ;
: ABS ( n -- u )  DUP 0< IF NEGATE THEN ;

: */ ( n1 n2 n3 -- n4 )  */MOD SWAP DROP ;
: /MOD ( n1 n2 -- n3 ) 1 SWAP */MOD ;

primitive U<
: WITHIN ( n1|u1 n2|u2 n3|u3 -- flag )  OVER - >R - R> U< ;
