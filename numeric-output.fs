\ Minimal Forth Workbench: numeric output                          uh 2015-10-15

primitive ALLOT
primitive um/mod
primitive d-

primitive TYPE
primitive SPACES
primitive SPACE

VARIABLE BASE  10 BASE !

: HEX ( -- )     16 BASE ! ;
: DECIMAL ( -- ) 10 BASE ! ;

: dnegate ( d1 -- d2 )   >r >r  0. r> r> d- ;

: dabs ( d1 -- d2 )  dup 0 < IF dnegate THEN ;

: ud/mod  
  >r 0 i um/mod r> swap >r um/mod r> ;

VARIABLE hld

CREATE <hold   100 CHARS DUP  ALLOT  <hold + CONSTANT hold>

: <# ( -- )  hold> hld ! ;

: hold ( c -- )  hld @ 1 - dup hld ! c! ; 

: # ( d -- d' )
     BASE @ ud/mod ROT 9 OVER < IF  7 + THEN  48 + HOLD ;

: #s  ( d -- d' )
  BEGIN  # OVER OVER or 0= UNTIL ;

: #> ( d -- c-addr len )  DROP DROP hld @ hold> over - ;

: sign    0 < IF  45 hold THEN ;

: ud.r ( d n -- )  >R <# #s #>  R> over - spaces type ;

: ud.    0 ud.r space ;

: u.r   0 swap ud.r ;
: u.    0 ud. ;

: d.r ( d n -- )  >r swap over  dabs <# #s rot sign #> r> over - spaces type ;

: d.  0 d.r space ;

: .r  >r DUP 0 < r> d.r ;
: .   DUP 0 <  d. ;

