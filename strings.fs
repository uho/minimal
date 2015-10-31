\ Minimal Forth Workbench: string words                                     uh 2015-10-15

32 CONSTANT BL

: SPACE ( -- )  BL EMIT ;
: SPACES ( u -- ) DUP 0 > IF  BEGIN DUP WHILE  SPACE 1 -  REPEAT  THEN  DROP ;

: COUNT ( addr1 -- addr2 len )  DUP CHAR+ SWAP C@ ;
: TYPE ( addr len -- )  BEGIN DUP WHILE  SWAP COUNT EMIT  SWAP 1 -  REPEAT DROP DROP ;
