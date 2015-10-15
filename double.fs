\ Minimal Forth Workbench: double words                                      uh 2015-10-15

: 2DUP ( d1 -- d1 d1 )  OVER OVER ;
: 2SWAP ( d1 d2 -- d2 d1 )  >R ROT ROT R> ROT ROT ;
: 2OVER ( d1 d2 -- d1 d2 d1 )  >R >R 2DUP R> R> 2SWAP ;

