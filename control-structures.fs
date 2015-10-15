\ Minimal Forth Workbench: control structure words                         uh 2015-10-15

primitive EXIT

: case? ( x1 x2 -- x1 ff | tf )  OVER = DUP IF  SWAP DROP EXIT THEN ;

: ?DUP ( x1 -- 0 | x2 x2 )  DUP IF DUP THEN ;

: BOUNDS ( addr1 u -- addr2 addr3 )  OVER + SWAP ;

