\ Minimal Forth Workbench: stack operators

: NIP ( x1 x2 -- x2 )  SWAP DROP ;
: TUCK ( x1 x2 -- x2 x1 x2 )  SWAP OVER ;
: -ROT ( x1 x2 x3 -- x3 x2 x1 )  ROT ROT ;