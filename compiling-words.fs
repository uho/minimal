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



: CASE ( -- ) ( C: -- n ) 0 ; IMMEDIATE
: OF ( x1 x2 -- | x1 )  >R POSTPONE OVER  POSTPONE = POSTPONE IF   POSTPONE DROP R> ; IMMEDIATE
: ENDOF ( -- ) ( C: n1 -- n2 )  >R POSTPONE ELSE  R> 1 + ; IMMEDIATE
: ENDCASE ( x1 -- ) ( C: n -- ) POSTPONE DROP  >R BEGIN R@ WHILE  POSTPONE THEN  R> 1 - >R REPEAT R> DROP ; IMMEDIATE


primitive COMPILE,
primitive [
primitive ]
