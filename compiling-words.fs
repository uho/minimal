\ Minimal Forth Workbench: compiling words                               uh 2015-10-15

primitive POSTPONE
primitive IMMEDIATE
primitive EXIT

: AHEAD   POSTPONE FALSE  POSTPONE IF ; IMMEDIATE
: ?EXIT   POSTPONE IF  POSTPONE EXIT  POSTPONE THEN ; IMMEDIATE
\ : AGAIN   POSTPONE FALSE  POSTPONE UNTIL ; IMMEDIATE


primitive LITERAL

: [']  ' POSTPONE LITERAL ; IMMEDIATE



primitive PARSE
primitive SLITERAL
primitive TYPE

: ."   34 PARSE POSTPONE SLITERAL POSTPONE TYPE ; IMMEDIATE
: .(   41 PARSE TYPE ; IMMEDIATE
: S"   34 PARSE POSTPONE SLITERAL ; IMMEDIATE

primitive WORD

: CHAR ( "<spaces>name"-- char )
   32 WORD CHAR+ C@ ;

: [CHAR] ( C: "<spaces>name" -- ) ( -- char )
   CHAR POSTPONE LITERAL ; IMMEDIATE


primitive STATE
primitive >BODY

: TO ( x "<spaces>name" -- ) 
   STATE @ 
   IF  POSTPONE [']  POSTPONE >BODY POSTPONE !  
   ELSE ' >BODY ! THEN ; IMMEDIATE

: IS ( x "<spaces>name" -- ) 
   STATE @ IF  POSTPONE TO  ELSE ['] TO EXECUTE  THEN ; IMMEDIATE

primitive COMPILE,
