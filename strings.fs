\ Minimal Forth Workbench: string words                                     uh 2015-10-15

32 CONSTANT BL

: SPACE ( -- )  BL EMIT ;
: SPACES ( u -- ) DUP 0 > IF  0 DO SPACE LOOP   ELSE DROP THEN ;

: COUNT ( addr1 -- addr2 len )  DUP CHAR+ SWAP C@ ;
: TYPE ( addr len -- )  DUP IF  OVER + SWAP DO  I C@ EMIT  LOOP  THEN ;
